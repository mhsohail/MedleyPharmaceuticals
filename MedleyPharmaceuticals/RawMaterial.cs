using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedleyPharmaceuticals.Model
{
    class RawMaterial
    {
        public int Id { get; set; }
        public System.DateTime ReceivingDate { get; set; }
        public string GRNNo { get; set; }
        public string MaterialName { get; set; }
        public string BatchNo { get; set; }
        public System.DateTime MfgDate { get; set; }
        public System.DateTime ExpDate { get; set; }
        public string QuantityReceived { get; set; }
        public int NoOfCartons { get; set; }
        public string Supplier { get; set; }
        public string ReferenceNo { get; set; }
        public bool DeliveredToStore { get; set; }
        public int StockId { get; set; }
    
        public virtual Stock Stock { get; set; }
    }
}
