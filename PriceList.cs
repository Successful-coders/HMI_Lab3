using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_Lab3
{
    public partial class PriceList : Form
    {
        private bool isResizing = false;
        private List<Category> categories = new List<Category>();


        public PriceList()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categories.Add(new Category("Cleaning", new List<Item>()
            {
                new Item("Regular cleaning", 30),
                new Item("Deep cleaning", 50),
                new Item("Laser cleaning", 180),
                new Item("Rich cleaning", 280),
            }));
            categories.Add(new Category("Dentures", new List<Item>()
            {
                new Item("Denture acrylic", 230),
                new Item("Denture Parcelain teeth", 350),
            }));
            categories.Add(new Category("Dentures 1", new List<Item>()
            {
                new Item("Denture acrylic", 230),
                new Item("Denture Parcelain teeth", 350),
            }));
            categories.Add(new Category("Dentures 2", new List<Item>()
            {
                new Item("Denture acrylic", 230),
                new Item("Denture Parcelain teeth", 350),
            }));

            categoryListView.AllowItemDrag = false;

            foreach (var category in categories)
            {
                ListViewGroup group = new ListViewGroup(category.Name);
                categoryListView.Groups.Add(group);

                foreach (var item in category.Items)
                {
                    categoryListView.Items.Add(new ListViewItem(item.Name, item.Cost, group));
                }
            }

            categoryListView_Resize(categoryListView, e);
        }

        #region AddNewCategory

        private void ShowNewCategoryPanel()
        {
            Point position = categoryListView.Items[categoryListView.Items.Count - 1].Position;
            position.Y += addCategoryPanel.Size.Height;
            addCategoryPanel.Location = position;

            categoryNameTextBox.Text = "";

            categoryListView.Controls.Add(addCategoryPanel);

            addCategoryPanel.Show();
        }
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddNewCategory(categoryNameTextBox.Text);

            ShowNewCategoryPanel();
        }
        private void categoryNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNewCategory((sender as TextBox).Text);

                //HideNewItemButtons();
                //ShowNewItemButtons();
                ShowNewCategoryPanel();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void AddNewCategory(string name)
        {
            if (string.IsNullOrEmpty(categoryNameTextBox.Text))
            {
                //message about empty textbox
                MessageBox.Show("Вы ввели пустое имя", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (categoryListView.HasGroupName(categoryNameTextBox.Text))
            {
                //message about existing of item with the same name
                MessageBox.Show("Категория с таким именем уже существует", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                ListViewGroup newGroup = new ListViewGroup(name);
                categoryListView.Groups.Add(newGroup);
                categoryListView.Items.Add(new ListViewItem("", 0, newGroup));
            }
        }
        #endregion

        #region AddNewItem
        private void ShowNewItemButtons()
        {
            for (int i = 1; i < categoryListView.Items.Count; i++)
            {
                if (categoryListView.Items[i - 1].Group != categoryListView.Items[i].Group)
                {
                    ShowNewItemButton(i, categoryListView.Items[i - 1].Group);
                    i++;
                }
            }
        }
        private void HideNewItemButtons()
        {
            var controls = categoryListView.Controls;
            for (int i = 0; i < controls.Count; i++)
            {
                if ((controls[i] is Button) && (controls[i] as Button).Tag.ToString() == "AddNewItem")
                {
                    controls[i].Hide();
                    controls.Remove(controls[i]);
                    i--;
                }
            }

            for (int i = 0; i < categoryListView.Items.Count; i++)
            {
                if (string.IsNullOrEmpty(categoryListView.Items[i].Text))
                {
                    categoryListView.Items.RemoveAt(i);
                    i--;
                }
            }
        }
        private void ShowNewItemButton(int lastItemIndex, ListViewGroup group)
        {
            var newPanel = addItemPanel.Clone();
            categoryListView.Items.Insert(lastItemIndex, new ListViewItem("", group));
            Point position = categoryListView.Items[lastItemIndex].Position;
            newPanel.Location = position;
            categoryListView.Controls.Add(newPanel);

            newPanel.Show();
        }
        private void addItemPanel_Click(object sender, EventArgs e)
        {
            //Add new item
        }
        #endregion

        private void editButton_CheckedChanged(object sender, EventArgs e)
        {
            if(editButton.Checked)
            {
                editButton.ImageIndex = 0;
                editButton.FlatAppearance.CheckedBackColor = Color.FromArgb(80, 90, 252);
                editButton.ForeColor = Color.White;

                //ShowNewItemButtons();
                ShowNewCategoryPanel();
            }
            else
            {
                editButton.ImageIndex = 1;
                editButton.FlatAppearance.CheckedBackColor = Color.White;
                editButton.ForeColor = Color.Black;

                //HideNewItemButtons();
                addCategoryPanel.Hide();
            }

            categoryListView.AllowItemDrag = editButton.Checked;
        }

        private void categoryListView_Resize(object sender, EventArgs e)
        {
            if (!isResizing)
            {
                isResizing = true;

                ListView listView = sender as ListView;
                if (listView != null)
                {
                    float totalColumnWidth = 0;

                    for (int i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }

            isResizing = false;
        }
    }
}
