using RealView.Core.Model;
using RealView.Core.Paginator;
using System;

namespace RealView.Core.Provider
{
    public class DataLoadedEventArgs : EventArgs
    {
        public ResourceSet ResourceSet;

        public DataLoadedEventArgs(ResourceSet res)
        {
            ResourceSet = res;
        }
    }
}