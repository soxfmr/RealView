using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealView.Core.Paginator
{
    public interface Paginator<T>
    {

        void NextPage();

        void PreviousPage();

        int Total();

        int Current();

        List<T> GetPageList();

    }
}
