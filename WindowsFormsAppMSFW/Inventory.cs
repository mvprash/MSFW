using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMSFW
{
    public class Inventory
    {
        public string ICode { get; set; }
        public string Description { get; set; }
        public int SupplierID { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int TotalUnits { get; set; }

        public int AvailableUnits { get; set; }

        public int CostPrice { get; set; }

        public int MaximumRetailPrice { get; set; }

        public int MaxDiscount { get; set; }

        public decimal CGST { get; set; }

        public decimal SGST { get; set; }

        public string HSN { get; set; }

        public string Sizes { get; set; }

    }
}
