using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrainsInterface
{
    public interface IHelloGrains : IGrainWithIntegerKey
    {
        Task<string> SayHello(string greeting);
    }
}

