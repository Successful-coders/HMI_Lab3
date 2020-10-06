using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMI_Lab3
{
    /// <summary>
    /// Provides data for the <see cref="ListView.ItemDragging"/> event of the <see cref="ListView"/> control.
    /// </summary>
    public class CancelListViewItemDragEventArgs : CancelEventArgs
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelListViewItemDragEventArgs"/> class.
        /// </summary>
        /// <param name="item">The source <see cref="ListViewItem"/> the event data relates to.</param>
        public CancelListViewItemDragEventArgs(ListViewItem item)
        {
            this.Item = item;
        }

        #endregion

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelListViewItemDragEventArgs"/> class.
        /// </summary>
        protected CancelListViewItemDragEventArgs()
        { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the <see cref="ListViewItem"/> that is the source of the drag operation.
        /// </summary>
        /// <value>The <see cref="ListViewItem"/> that initiated the drag operation.</value>
        public ListViewItem Item { get; protected set; }

        #endregion
    }
}
