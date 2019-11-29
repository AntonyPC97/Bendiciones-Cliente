using System;
using System.Text;
using System.Security.Cryptography;

namespace Bendiciones
{
	public class Encriptar
    {
        public static string HashTable(string password)
		{
			byte[] arrbyte = new byte[password.Length];
			SHA256 hash = new SHA256CryptoServiceProvider();
			arrbyte = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
			return Convert.ToBase64String(arrbyte);
		}
    }
}
