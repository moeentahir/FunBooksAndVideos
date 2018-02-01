using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public class Commodity
    {
        public string Name { get; set; }
        public List<IRule<Commodity>> PostProcessingRules { get; }

        public Commodity(List<IRule<Commodity>> postProcessingRules)
        {
            PostProcessingRules = postProcessingRules;
        }

        public void RunPostProcessingRules()
        {
            foreach (var rule in PostProcessingRules)
            {
                rule.Run(this);
            }
        }
    }
}
