using RealView.Core.Model;
using RealView.Providers;
using RealView.Providers.KickAss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealView.Core
{
    public class App
    {
        public static ProviderInfo[] Providers = {
            new ProviderInfo { Alias = "KickAssTorrent", ProviderImpl = typeof(KickAssProvider), Parser = typeof(KickAssParser) }
        };
    }
}
