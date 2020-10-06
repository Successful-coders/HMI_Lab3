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

            categoryListView.AllowItemDrag = true;

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

        private bool isResizing = false;
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
