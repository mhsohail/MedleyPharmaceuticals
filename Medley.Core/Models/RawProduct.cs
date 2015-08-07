using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medley.UI.Models
{
    public class RawProduct
    {
        public int RawProductId { get; set; }
        public DateTime ReceivingDate { get; set; }
        public string GRNNo { get; set; }
        public string MaterialName { get; set; }
        public string BatchNo { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int QuantityReceived { get; set; }
        public int NoOfCartons { get; set; }
        public string ManufacturerOrSupplier { get; set; }
        public string BuiltyOrReferenceNo { get; set; }
        public int CategoryId { get; set; }
        
        public virtual Category Category { get; set; }
    }
}
