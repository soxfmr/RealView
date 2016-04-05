using RealView.Core.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealView.Core.Provider
{
    public class ProviderFactory
    {
        private static Dictionary<string, Provider> ProviderContainer = new Dictionary<string, Provider>();

        public static Provider CreateProvider(string name, EventHandler<DataLoadedEventArgs> callback)
        {
            Provider provider = null;

            if (ProviderContainer.ContainsKey(name))
            {
                return ProviderContainer[name];
            }

            foreach (var info in App.Providers)
            {
                if (info.Alias == name)
                {
                    ParserContract parser = (ParserContract) Activator.CreateInstance(info.Parser);
                    provider = (Provider) Activator.CreateInstance(info.ProviderImpl);
                    provider.setTag(parser);

                    provider.DataLoadedEventHandler += callback;

                    ProviderContainer[name] = provider;
                }
            }

            return provider;
        }
    }
}
