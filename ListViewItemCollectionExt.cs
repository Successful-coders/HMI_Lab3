using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace HMI_Lab3
{
    public static class ListViewItemCollectionExt
    {
        public static void RemoveEmpty(this ListViewItemCollection list, ListViewGroup group)
        {
            foreach (ListViewItem item in list)
            {
                if(item.Group == group && item.Text == "")
                {
                    list.Remove(item);
                    return;
                }
            }
        }
        public static void RemoveEmpties(this ListViewItemCollection list)
        {
            foreach (ListViewItem item in list)
            {
                if(item.Text == "")
                {
                    list.Remove(item);
                    return;
                }
            }
        }
    }
}
