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

        List<Inventory> listInv = new List<Inventory> { new Inventory { InvID=1, ICode = "SS", Description = "Desc", TotalUnits = 10, AvailableUnits = 10, DateOfPurchase = Convert.ToDateTime("2022-01-21"), SupplierID = 1, Rate = 92, MaximumRetailPrice = 250, MaxDiscount = 10, SGST = 0, CGST = 0, IGST = 12, HSN = "6404", Sizes = "6-9",DateOfEntry=DateTime.Now } };

        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            frmInventoryAdd frmAdd = new frmInventoryAdd();
            frmAdd.listInventory = listInv;
            frmAdd.ShowDialog();

            this.listInv = frmAdd.listInventory;

            loadDataGrid();

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dataGridViewInventory.DataSource = listInv;
            
        }
        private void loadDataGrid()
        {
            dataGridViewInventory.DataSource = null;
            dataGridViewInventory.DataSource = this.listInv;
            dataGridViewInventory.Update();
            dataGridViewInventory.Refresh();

        }
    }
}
