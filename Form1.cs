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
    public partial class Form1 : Form
    {
        List<Category> categories = new List<Category>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            categories.Add(new Category("Cleaning", new List<Item>()
            {
                new Item("Regular cleaning", 30),
                new Item("Deep cleaning", 50),
                new Item("Laser cleaning", 180),
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

            ShowList();

            itemcreator_Load(sender, e);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Delete it
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (categoryList.SelectedItem == null)
                return;
            categoryList.DoDragDrop(categoryList.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = categoryList.PointToClient(new Point(e.X, e.Y));
            int index = categoryList.IndexFromPoint(point);

            if (index < 0)
            {
                index = categoryList.Items.Count - 1;
            }

            Category data = categoryList.SelectedItem as Category;

            categories.Remove(data);
            categories.Insert(index, data);

            ShowList();
        }

        private void ShowList()
        {
            categoryList.DataSource = null;
            categoryList.DisplayMember = "Name";
            categoryList.ValueMember = "ValueMember";
            categoryList.DataSource = categories;
        }

        private void itemcreator_Load(object sender, EventArgs e)
        {
            categoryList.AllowDrop = true;
        }
    }
}
