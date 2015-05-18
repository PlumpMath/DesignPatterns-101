using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// When implementing the adapter pattern, for clarity one can apply the class name [AdapteeClassName]To[Interface]Adapter to the provider implementation,
    /// for example DaoToProviderAdapter. It should have a constructor method with an adaptee class variable as a parameter.
    /// This parameter will be passed to an instance member of [AdapteeClassName]To[Interface]Adapter.
    /// </summary>
    public class AdapteeToClientAdapter : IClient
    {
        public IAdaptee _adaptee;

        public AdapteeToClientAdapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public bool ClientMethod()
        {
            return _adaptee.AdapteeMethod(false) != 4;
        }
    }
}
