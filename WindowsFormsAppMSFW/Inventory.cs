using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMSFW
{
    public class Inventory
    {
        public int InvID { get; set; }
        public string ICode { get; set; }
        public string Description { get; set; }
        public string HSN { get; set; }
        public int SupplierID { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int TotalUnits { get; set; }

        public int AvailableUnits { get; set; }

        public int Rate { get; set; }

        public int MaximumRetailPrice { get; set; }

        public int MaxDiscount { get; set; }

        public decimal CGST { get; set; }

        public decimal SGST { get; set; }

        public decimal IGST { get; set; }

        public string Sizes { get; set; }

        public DateTime DateOfEntry { get; set; }

    }
}
