using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedsOnline.Models
{
    public class tbPurchaseHeader
    {

        /* ==== */
        /* Mapping Columns */
        [Key]
        [Column(Order = 0)]
        public int GRNID { get; set; }

        [Column(Order = 1)]
        public DateTime GRNDate { get; set; }

       [Column(Order = 2)]
       public string SupplierType { get; set; }

        [Column(Order = 3)]
        public string SupplierID { get; set; }

        [Column(Order = 4)]
        public string SupplierName { get; set; }

        [Column(Order = 5)]
        public string SupplierCash { get; set; }

        [Column(Order = 6)]
        public int TotalQty { get; set; }

        [Column(Order = 7)]
        public int TotalAmount { get; set; }
        /* ==== */


        /* ==== */
        /* Maintance */
        [Column(Order = 8)]
        public int CreatedBy { get; set; }

        [Column(Order = 9)]
        public DateTime? CreatedOn { get; set; }
        
        [Column(Order = 10)]
        public int DeletedBy { get; set; }
        /* ==== */
    }
}
