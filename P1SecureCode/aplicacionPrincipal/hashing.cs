using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace aplicacionPrincipal
{
    public class hashing
    {
        public string hashingConAleatorio(int numAleatorio)
        {
            string valorHashed;

            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(numAleatorio.ToString()));
                string strHash = BitConverter.ToString(hashedBytes);
                valorHashed = strHash;
            }

            return valorHashed;
        }

        public string hashingPass(string sal, string password)
        {
            string valorHashed;
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password + sal));
                string strHash = BitConverter.ToString(hashedBytes);
                valorHashed = strHash;
            }
            return valorHashed;
        }
    }
}
