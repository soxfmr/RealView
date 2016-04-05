using RealView.Core.Parser;

namespace RealView.Core.Provider
{
    public interface ProviderContract
    {
        /// <summary>
        /// The name of the provider
        /// </summary>
        string GetName();

        /// <summary>
        /// The description for the provider
        /// </summary>
        string GetDescription();

        void Load(string keyword, ParserContract parser);
    }
}
