using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBooksAndVideos.Framework
{
    public interface IBusinessRule<T>
    {
        bool WasActionSuccessfullyPerformed { get; set; }

        bool IsApplicable(T businessObject);

        void PerfromAction(T businessObject);
    }
}
