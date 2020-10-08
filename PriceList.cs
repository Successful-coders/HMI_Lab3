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

            categoryListView.Controls.Add(addCategoryPanel);

            categoryListView.ItemDragDrop += CategoryListView_ItemDragDrop;

            categoryListView_Resize(categoryListView, e);
        }


        #region AddNewCategory

        private void SetNewCategoryPanel(bool isEnable)
        {
            if (isEnable)
            {
                Point position = categoryListView.Items[0].Position;
                foreach (ListViewItem item in categoryListView.Items)
                {
                    position.Y = Math.Max(item.Position.Y, position.Y);
                }
                position.Y += addCategoryPanel.Size.Height;
                addCategoryPanel.Location = position;

                categoryNameTextBox.Text = "";
            }

            addCategoryPanel.Visible = isEnable;
        }
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            AddNewCategory(categoryNameTextBox.Text);

            SetNewCategoryPanel(true);
        }
        private void categoryNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool isSucessful = AddNewCategory((sender as TextBox).Text);

                //HideNewItemButtons();
                //ShowNewItemButtons();
                if (isSucessful)
                {
                    SetNewCategoryPanel(true);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private bool AddNewCategory(string name)
        {
            if (string.IsNullOrEmpty(categoryNameTextBox.Text))
            {
                MessageBox.Show("Вы ввели пустое имя", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                return false;
            }
            else if (categoryListView.HasGroupName(categoryNameTextBox.Text))
            {
                MessageBox.Show("Категория с таким именем уже существует", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                return false;
            }
            else
            {
                ListViewGroup newGroup = new ListViewGroup(name);
                categoryListView.Groups.Add(newGroup);
                categoryListView.Items.Add(new ListViewItem("", 0, newGroup));

                return true;
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
            if (editButton.Checked)
            {
                editButton.ImageIndex = 0;
                editButton.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
                editButton.ForeColor = Color.White;

                //ShowNewItemButtons();
            }
            else
            {
                editButton.ImageIndex = 1;
                editButton.FlatAppearance.CheckedBackColor = Color.White;
                editButton.ForeColor = Color.Black;

                //HideNewItemButtons();
                categoryListView.Items.RemoveEmpties();
            }

            SetNewCategoryPanel(editButton.Checked);
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
        private void CategoryListView_ItemDragDrop(object sender, ListViewItemDragEventArgs e)
        {
            SetNewCategoryPanel(true);
        }
    }
}
