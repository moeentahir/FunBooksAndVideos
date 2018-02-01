using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class Product : Commodity
    {
        public ProductType Type { get; set; }

        public Product(string name, ProductType type, List<IRule<Product>> postProcessingRules) : base(postProcessingRules)
        {
            Name = name;
            Type = type;
        }
    }
}
