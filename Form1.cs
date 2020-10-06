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

        // Starts the drag-and-drop operation when an item is dragged.
        private void categoryListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            categoryListView.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        // Sets the target drop effect.
        private void categoryListView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        // Moves the insertion mark as the item is dragged.
        private void categoryListView_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse pointer.
            Point targetPoint = categoryListView.PointToClient(new Point(e.X, e.Y));

            // Retrieve the index of the item closest to the mouse pointer.
            int targetIndex = categoryListView.InsertionMark.NearestIndex(targetPoint);

            // Confirm that the mouse pointer is not over the dragged item.
            if (targetIndex > -1)
            {
                // Determine whether the mouse pointer is to the left or
                // the right of the midpoint of the closest item and set
                // the InsertionMark.AppearsAfterItem property accordingly.
                Rectangle itemBounds = categoryListView.GetItemRect(targetIndex);
                if (targetPoint.X > itemBounds.Left + (itemBounds.Width / 2))
                {
                    categoryListView.InsertionMark.AppearsAfterItem = true;
                }
                else
                {
                    categoryListView.InsertionMark.AppearsAfterItem = false;
                }
            }

            // Set the location of the insertion mark. If the mouse is
            // over the dragged item, the targetIndex value is -1 and
            // the insertion mark disappears.
            categoryListView.InsertionMark.Index = targetIndex;
        }

        // Removes the insertion mark when the mouse leaves the control.
        private void categoryListView_DragLeave(object sender, EventArgs e)
        {
            categoryListView.InsertionMark.Index = -1;
        }

        // Moves the item to the location of the insertion mark.
        private void categoryListView_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the index of the insertion mark;
            int targetIndex = categoryListView.InsertionMark.Index;

            // If the insertion mark is not visible, exit the method.
            if (targetIndex == -1)
            {
                return;
            }

            // If the insertion mark is to the right of the item with
            // the corresponding index, increment the target index.
            if (categoryListView.InsertionMark.AppearsAfterItem)
            {
                targetIndex++;
            }

            // Retrieve the dragged item.
            ListViewItem draggedItem =
                (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            // Insert a copy of the dragged item at the target index.
            // A copy must be inserted before the original item is removed
            // to preserve item index values.
            categoryListView.Items.Insert(
                targetIndex, (ListViewItem)draggedItem.Clone());

            // Remove the original copy of the dragged item.
            categoryListView.Items.Remove(draggedItem);
        }
    }
}
