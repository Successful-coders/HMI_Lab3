using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI_Lab3
{
    /// <summary>
    /// Determines the insertion mode of a drag operation
    /// </summary>
    public enum InsertionMode
    {
        /// <summary>
        /// The source item will be inserted before the destination item
        /// </summary>
        Before,

        /// <summary>
        /// The source item will be inserted after the destination item
        /// </summary>
        After
    }
}
