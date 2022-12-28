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
        public List<Inventory> listInventory { get; set; }
        public frmInventoryAdd()
        {
            InitializeComponent();
        }

        private void frmInventoryAdd_Load(object sender, EventArgs e)
        {

            List<Supplier> listSupplier = new List<Supplier> { new Supplier { SupplierID = 1, Name = "Neerala Traders" },new Supplier{SupplierID=2,Name="Sri Swamy Footwear"}
            ,new Supplier{SupplierID=3,Name="FLOW Enterprises"}};
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "SupplierID";
            cmbSupplier.DataSource = listSupplier;
            string strRandomCode = string.Empty;

            strRandomCode = DateTime.Now.Year.ToString() + "-" + getMaxCode().ToString().PadLeft(4,'0');

            this.labelICValue.Text = strRandomCode;


        }

        private int getMaxCode()
        {
            if (listInventory.Count > 0)
            {
                if (listInventory.Where(a => a.DateOfEntry.Year == DateTime.Now.Year).Count() > 0)
                    return (listInventory.Where(a => a.DateOfEntry.Year == DateTime.Now.Year).Max(a => a.InvID)+1);
                else
                    return 1;
            }
            else
                return 1;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(textBoxTU.Text) || string.IsNullOrEmpty(textBoxDesc.Text) || string.IsNullOrEmpty(textBoxHSN.Text)
                    || string.IsNullOrEmpty(textBoxsizes.Text) || string.IsNullOrEmpty(textBoxAU.Text) || string.IsNullOrEmpty(textBoxRate.Text)
                    || string.IsNullOrEmpty(textBoxCGST.Text) || string.IsNullOrEmpty(textBoxSGST.Text) || string.IsNullOrEmpty(textBoxIGST.Text)
                    || string.IsNullOrEmpty(textBoxMRP.Text) || string.IsNullOrEmpty(textBoxMD.Text))
            {
                MessageBox.Show("Empty Field");
                return;
            }
            else
            {
                Inventory i = new Inventory();
                
                i.InvID =listInventory.Max(a=>a.InvID)+1;
                i.ICode= labelICValue.Text;
                i.Description  =textBoxDesc.Text;
                i.HSN   =textBoxHSN.Text;
                i.SupplierID  =cmbSupplier.SelectedIndex;
                i.DateOfPurchase  = dateTimePickerDOP.Value;
                i.TotalUnits  = Convert.ToInt16(textBoxTU.Text);
                i.AvailableUnits  =Convert.ToInt16(textBoxAU.Text);
                i.Rate  =Convert.ToInt16(textBoxRate.Text);
                i.MaximumRetailPrice  =Convert.ToInt16(textBoxMRP.Text);
                i.MaxDiscount   =Convert.ToInt16(textBoxMD.Text);
                i.CGST  =Convert.ToDecimal(textBoxCGST.Text);
                i.SGST  =Convert.ToDecimal(textBoxSGST.Text);
                i.IGST  =Convert.ToDecimal(textBoxIGST.Text);
                i.Sizes  =textBoxsizes.Text;
                i.DateOfEntry = DateTime.Now;

                listInventory.Add(i);

            }
            
        }

      
    }
}
