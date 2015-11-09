using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApiTokenAuth.Services
{
    public interface IHashProvider
    {
        byte[] ComputeHash(byte[] data);
    }
}