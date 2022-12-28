using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMSFW
{
    public partial class frmInventoryAdd : Form
    {
        public List<Inventory> MyProperty { get; set; }
        public frmInventoryAdd()
        {
            InitializeComponent();
        }

      
    }
}
