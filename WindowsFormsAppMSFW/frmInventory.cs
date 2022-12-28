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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Inventory> list=new List<Inventory> { new Inventory{ICode="SS",Description="Desc",TotalUnits=10,AvailableUnits=10,DateOfPurchase=Convert.ToDateTime("2022-01-21"),SupplierID=1,CostPrice=100,MaxDiscount cCcf}
        }
    }
}
