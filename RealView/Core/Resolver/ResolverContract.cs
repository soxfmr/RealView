using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealView.Core.Resolver
{
    public interface ResolverContract
    {
        void Resolve(string title);

        void ResolveByIdentifier(string identifier);
    }
}
