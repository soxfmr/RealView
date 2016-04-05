using RealView.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealView.Core.Parser
{
    public interface ParserContract
    {
        ResourceSet Parse(object o);
    }
}
