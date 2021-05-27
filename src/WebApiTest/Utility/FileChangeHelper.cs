using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTest.Utility
{
    public class FileChangeHelper
    {

        public static string CreatePathToMD5(string path)
        {
            using (var md5 = MD5.Create())
            {
                byte[] encData = File.ReadAllBytes(path);
                byte[] md5Hash = md5.ComputeHash(encData);

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < md5Hash.Length; i++)
                {
                    sBuilder.Append(md5Hash[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }


        public static string GetMd5Hash(string filePath)
        {
            using var md5 = MD5.Create();

            using var stream = File.OpenRead(filePath);
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }



    }
}
