using RealView.Core.Model;
using RealView.Core.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealView.Core.Provider
{
    public abstract class Provider : ProviderContract
    {
        private object Tag;

        public EventHandler<DataLoadedEventArgs> DataLoadedEventHandler;

        public virtual string GetDescription()
        {
            throw new NotImplementedException();
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }

        public virtual void Load(string keyword, ParserContract parser)
        {
            throw new NotImplementedException();
        }

        public void NotifyDataChanged(ResourceSet res)
        {
            if (DataLoadedEventHandler == null)
            {
                // No handler present
                return;
            }

            DataLoadedEventHandler(this, new DataLoadedEventArgs(res));
        }

        public void setTag(object o)
        {
            Tag = o;
        }

        public object getTag()
        {
            return Tag;
        }
    }
}
