using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MedsOnline.Models
{
    public class tbPurchaseDetails
    {
        /* ==== */
        /* Mapping Columns */

        [Key]
        [Column(Order = 0)]
        public int GRNDetId { get; set; }

        [Column(Order = 1)]
        public int GRNID { get; set; }

        [Column(Order = 2)]
        public int ProductCode { get; set; }

        
        [Column(Order = 3)]
        public String ProductName { get; set; }


        [Column(Order = 4)]
        public int PurchaseRate { get; set; }

        [Column(Order = 5)]
        public int PurchaseQuantity { get; set; }

        [Column(Order = 6)]
        public Decimal PurchaseAmount { get; set; }
        /* ==== */
        
        /* ==== */
        /* Maintance */
        [Column(Order = 7)]
        public int CreatedBy { get; set; }

        [Column(Order = 8)]
        public DateTime? CreatedOn { get; set; }
        
        [Column(Order = 9)]
        [DefaultValue(0)]
        public int DelFlag { get; set; }

    }
}
