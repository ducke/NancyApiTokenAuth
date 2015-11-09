using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Services
{
    public interface IHashProvider
    {
        byte[] ComputeHash(byte[] data);
    }
}