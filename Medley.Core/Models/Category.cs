using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medley.UI.Models
{
    public class Category
    {
        private readonly ObservableListSource<RawProduct> _products = new ObservableListSource<RawProduct>();
        public int CategoryId { get; set; }
        public string Name { get; set; }
        
        public virtual ObservableListSource<RawProduct> Products { get { return _products; } }
    }
}
