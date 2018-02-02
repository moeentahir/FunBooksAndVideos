using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public interface IBusinessRuleEngine<T>
    {
        List<IBusinessRule<T>> Rules { get; }

        void Run(T item);
    }
}
