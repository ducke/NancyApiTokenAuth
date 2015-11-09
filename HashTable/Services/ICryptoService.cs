using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Services
{
    public interface ICryptoService
    {
        void CreateHash(byte[] data, out byte[] hash, out byte[] salt);

        byte[] ComputeHash(byte[] data, byte[] salt);
    }
}