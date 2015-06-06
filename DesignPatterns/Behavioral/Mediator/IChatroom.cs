using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    /// <summary>
    /// IMediator
    /// </summary>
    public interface IChatroom
    {
        void Register(Participant participant);

        void Send(string from, string to, string message);
    }
}
