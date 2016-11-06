using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enact_group.net.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
