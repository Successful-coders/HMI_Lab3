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
    public partial class PriceListForm : Form, ISignable
    {
        private List<Category> categories = new List<Category>();
        private List<Panel> newItemPanels = new List<Panel>();


        public PriceListForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitStartItems();

            InitListView(categories);

            categoryListView.AllowItemDrag = false;
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
            ListViewItem listItem = categoryListView.Items.Add(new ListViewItem(new string[] { "", "", "" }, group));
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
            hintTextBox1.Name = "hintTextBox1";
            hintTextBox1.Size = new System.Drawing.Size(438, 20);
            hintTextBox1.TabIndex = 5;
            hintTextBox1.KeyDown += AddItemPanel;
            hintTextBox1.MaxLength = 25;
            // 
            // hintTextBox2
            // 
            hintTextBox2 = new HintTextBox();

            hintTextBox2.Cue = "Цена";
            hintTextBox2.Location = new System.Drawing.Point(481, 4);
            hintTextBox2.Name = "hintTextBox2";
            hintTextBox2.Size = new System.Drawing.Size(189, 20);
            hintTextBox2.TabIndex = 5;
            hintTextBox2.KeyPress += CheckNumberEnter;
            hintTextBox2.KeyDown += AddItemPanel;
            hintTextBox2.MaxLength = 8;

            // 
            // hintTextBox3
            // 
            hintTextBox3 = new HintTextBox();

            hintTextBox3.Cue = "Ед. изм.";
            hintTextBox3.Location = new System.Drawing.Point(682, 4);
            hintTextBox3.Name = "hintTextBox3";
            hintTextBox3.Size = new System.Drawing.Size(91, 20);
            hintTextBox3.TabIndex = 5;
            hintTextBox3.KeyDown += AddItemPanel;
            hintTextBox3.MaxLength = 8;
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
            addItemPanel.Controls.Add(hintTextBox3);
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
        private void CheckNumberEnter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
                categoryListView.Items.Add(new ListViewItem(new string[] { addItemPanel.Controls[0].Text, addItemPanel.Controls[1].Text , addItemPanel.Controls[2].Text },
                    addItemPanel.Tag as ListViewGroup));

                categories = GetFromListView();
                InitListView(categories);

                HideNewItemButtons();
                ShowNewItemButtons();

                SetNewCategoryPanel(true);
            }
        }
        #endregion

        #region FormEvents
        private void editButton_CheckedChanged(object sender, EventArgs e)
        {
            if (editButton.Checked)
            {
                editButton.ImageIndex = 0;
                editButton.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
                editButton.ForeColor = Color.White;

                noSearchResultLabel.Visible = false;

                ClearSearch();
                ShowNewItemButtons();
            }
            else
            {
                editButton.ImageIndex = 1;
                editButton.FlatAppearance.CheckedBackColor = Color.White;
                editButton.ForeColor = Color.Black;

                HideNewItemButtons();

                categories = GetFromListView();
                InitListView(categories);
            }

            SetNewCategoryPanel(editButton.Checked);
            categoryListView.AllowItemDrag = editButton.Checked;

            searchBox.Enabled = !editButton.Checked;
            searchButton.Enabled = !editButton.Checked;
        }
        private void categoryListView_Resize(object sender, EventArgs e)
        {
            categoryListView.Columns[0].Width = 490;
            categoryListView.Columns[1].Width = 200;
            categoryListView.Columns[2].Width = 100;
        }
        private void CategoryListView_ItemDragged(object sender, ListViewItemDragEventArgs e)
        {
            categories = GetFromListView();
            InitListView(categories);

            HideNewItemButtons();
            ShowNewItemButtons();

            SetNewCategoryPanel(true);

            categoryListView.Refresh();
        }
        #endregion

        #region DataBaseWork
        private List<Category> GetFromListView()
        {
            categoryListView.RemoveEmpty();
            List<Category> categories = new List<Category>();

            foreach (ListViewGroup group in categoryListView.Groups)
            {
                List<Item> items = new List<Item>();
                foreach (ListViewItem item in group.Items)
                {
                    items.Add(new Item(item.SubItems[0].Text, int.Parse(item.SubItems[1].Text), item.SubItems[2].Text));
                }
                categories.Add(new Category(group.Header, items));
            }

            return categories;
        }
        private void InitListView(List<Category> categories)
        {
            categoryListView.Items.Clear();
            categoryListView.Groups.Clear();

            foreach (var category in categories)
            {
                ListViewGroup group = new ListViewGroup(category.Name);
                categoryListView.Groups.Add(group);

                foreach (var item in category.Items)
                {
                    categoryListView.Items.Add(new ListViewItem(new string[] { item.Name, item.Cost.ToString(), item.Unit }, group));
                }
            }
        }
        private void InitStartItems()
        {
            categories.Add(new Category("Чистка зубов", new List<Item>()
            {
                new Item("Регулярная чиста", 30),
                new Item("Глубокая чистка", 50),
                new Item("Лазерная чиста", 180),
                new Item("Полная чистка", 280),
            }));
            categories.Add(new Category("Зубные протезы", new List<Item>()
            {
                new Item("Акриловые", 1230),
                new Item("Фарфоровые", 1350),
            }));
            categories.Add(new Category("Коронка", new List<Item>()
            {
                new Item("Металлическая", 230),
                new Item("Фарфоровая", 350),
                new Item("Золотая", 350),
            }));
        }
        #endregion

        #region SigningIn
        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm(this);
            signInForm.Show();
        }
        public void SignIn(string login, string password)
        {
            signInButton.Visible = false;
            signInLabel.Visible = false;
            editButton.Visible = true;
        }
        #endregion

        #region Search
        private void Search()
        {
            categoryListView.Items.Clear();
            int itemsCount = 0;

            List<Category> filteredCategories = new List<Category>();
            foreach (var category in categories)
            {
                List<Item> items = category.Items.Where(i => string.IsNullOrEmpty(searchBox.Text.ToLower()) || i.Name.ToLower().StartsWith(searchBox.Text.ToLower())).ToList();

                filteredCategories.Add(new Category(category.Name, items));
                itemsCount += items.Count;
            }

            noSearchResultLabel.Visible = itemsCount <= 0;

            InitListView(filteredCategories);
        }
        private void ClearSearch()
        {
            searchBox.Text = "";
            categoryListView.Items.Clear();

            InitListView(categories);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }
        #endregion
    }
}
