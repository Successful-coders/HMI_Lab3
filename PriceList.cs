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
    public partial class PriceList : Form, ISignable
    {
        private bool isResizing = false;
        private List<Category> categories = new List<Category>();
        private List<Panel> newItemPanels = new List<Panel>();


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

            LoadFromDataBase();

            categoryListView.Controls.Add(addCategoryPanel);

            categoryListView.ItemDragged += CategoryListView_ItemDragged;

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
                ShowNewItemButton(newGroup);

                return true;
            }
        }
        #endregion

        #region AddNewItem
        private void ShowNewItemButtons()
        {
            foreach (ListViewGroup group in categoryListView.Groups)
            {
                ShowNewItemButton(group);
            }
        }
        private void ShowNewItemButton(ListViewGroup group)
        {
            var newPanel = CreateAddItemPanel(group);
            ListViewItem listItem = categoryListView.Items.Add(new ListViewItem("", group));
            Point position = listItem.Position;
            position.Y -= 2;
            newPanel.Location = position;

            categoryListView.Controls.Add(newPanel);

            newPanel.Show();

            newItemPanels.Add(newPanel);
        }
        private Panel CreateAddItemPanel(ListViewGroup group)
        {
            Panel addItemPanel = new Panel();
            addItemPanel.SuspendLayout();

            // 
            // hintTextBox1
            // 
            hintTextBox1 = new HintTextBox();

            hintTextBox1.Cue = "Имя товара";
            hintTextBox1.Location = new System.Drawing.Point(30, 4);
            hintTextBox1.Name = "ItemNameTextBox";
            hintTextBox1.Size = new System.Drawing.Size(313, 20);
            hintTextBox1.TabIndex = 6;
            hintTextBox1.KeyDown += AddItemPanel;
            // 
            // hintTextBox2
            // 
            hintTextBox2 = new HintTextBox();

            hintTextBox2.Cue = "Цена";
            hintTextBox2.Location = new System.Drawing.Point(350, 4);
            hintTextBox2.Name = "ItemCostTextBox";
            hintTextBox2.Size = new System.Drawing.Size(91, 20);
            hintTextBox2.TabIndex = 6;
            hintTextBox2.KeyDown += AddItemPanel;
            // 
            // pictureBox3
            // 
            pictureBox3 = new PictureBox();

            pictureBox3.Image = global::HMI_Lab3.Properties.Resources.plus;
            pictureBox3.InitialImage = global::HMI_Lab3.Properties.Resources.plus;
            pictureBox3.Location = new System.Drawing.Point(4, 3);
            pictureBox3.Name = "PlusItemButton";
            pictureBox3.Size = new System.Drawing.Size(20, 20);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += new EventHandler(AddItemPanel);

            addItemPanel.Controls.Add(hintTextBox1);
            addItemPanel.Controls.Add(hintTextBox2);
            addItemPanel.Controls.Add(pictureBox3);
            addItemPanel.Location = new System.Drawing.Point(12, 378);
            addItemPanel.Name = "addItemPanel";
            addItemPanel.Tag = group;
            addItemPanel.Size = new System.Drawing.Size(776, 24);
            addItemPanel.TabIndex = 6;

            return addItemPanel;
        }
        private void HideNewItemButtons()
        {
            newItemPanels.ForEach(x => x.Dispose());
            newItemPanels = new List<Panel>();
        }

        private void AddItemPanel(object sender, EventArgs e)
        {
            Panel addItemPanel;
            if (e is KeyEventArgs && (e as KeyEventArgs).KeyCode == Keys.Enter)
            {
                addItemPanel = (sender as Control).Parent as Panel;
            }
            else if(sender is PictureBox)//Button
            {
                addItemPanel = (sender as Control).Parent as Panel;
            }
            else
            {
                return;
            }

            if (addItemPanel.Controls[0].Text == "")
            {
                MessageBox.Show("Вы ввели пустое значение", "Сообщение", MessageBoxButtons.OK,
    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if(addItemPanel.Controls[1].Text == "")
            {
                MessageBox.Show("Вы ввели пустое значение", "Сообщение", MessageBoxButtons.OK,
MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if(categoryListView.HasItem(addItemPanel.Controls[0].Text, addItemPanel.Tag as ListViewGroup))
            {
                MessageBox.Show("Товар с таким именем в текущей категории уже существует", "Сообщение", MessageBoxButtons.OK,
     MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                categoryListView.Items.Add(new ListViewItem(addItemPanel.Controls[0].Text, addItemPanel.Tag as ListViewGroup));

                SaveToDataBase();
                LoadFromDataBase();

                HideNewItemButtons();
                ShowNewItemButtons();

                SetNewCategoryPanel(true);
            }
        }
        #endregion

        private void editButton_CheckedChanged(object sender, EventArgs e)
        {
            if (editButton.Checked)
            {
                editButton.ImageIndex = 0;
                editButton.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
                editButton.ForeColor = Color.White;

                ShowNewItemButtons();
            }
            else
            {
                editButton.ImageIndex = 1;
                editButton.FlatAppearance.CheckedBackColor = Color.White;
                editButton.ForeColor = Color.Black;

                HideNewItemButtons();

                SaveToDataBase();
                LoadFromDataBase();
            }

            SetNewCategoryPanel(editButton.Checked);
            categoryListView.AllowItemDrag = false;
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
        private void CategoryListView_ItemDragged(object sender, ListViewItemDragEventArgs e)
        {
            SaveToDataBase();
            LoadFromDataBase();

            HideNewItemButtons();
            ShowNewItemButtons();

            SetNewCategoryPanel(true);

            categoryListView.Refresh();
        }

        private void SaveToDataBase()
        {
            categoryListView.RemoveEmpty();
            categories = new List<Category>();
            List<Item> items = new List<Item>();

            foreach (ListViewGroup group in categoryListView.Groups)
            {
                items = new List<Item>();
                foreach (ListViewItem item in group.Items)
                {
                    items.Add(new Item(item.Text, 0));
                }
                categories.Add(new Category(group.Header, items));
            }
        }
        private void LoadFromDataBase()
        {
            categoryListView.Items.Clear();
            categoryListView.Groups.Clear();

            foreach (var category in categories)
            {
                ListViewGroup group = new ListViewGroup(category.Name);
                categoryListView.Groups.Add(group);

                foreach (var item in category.Items)
                {
                    categoryListView.Items.Add(new ListViewItem(item.Name, item.Cost, group));
                }
            }
        }

        //Signing in
        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm(this);
            signInForm.Show();
        }
        public void SignIn(string login, string password)
        {
            signInButton.Visible = false;
            editButton.Visible = true;
        }
    }
}
