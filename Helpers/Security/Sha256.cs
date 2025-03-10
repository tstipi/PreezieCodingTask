﻿using System.Security.Cryptography;
using System.Text;

namespace PreezieCodingTask.Helpers
{
    public class Sha256
    {
        public static string GetHash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2").ToUpper());
                }
                return builder.ToString();
            }
        }
    }
}
