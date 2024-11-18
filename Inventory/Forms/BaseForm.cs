using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class BaseForm : UserControl
    {
        public virtual bool isFullScreen()
        {
            return true;
        }

        public virtual void OnLoad() { }
    }
}
