using System.Text;

namespace MovieApp.Commons
{
    public class PasswordHelper
    {
        public static string BytesToHex(byte[] bytes)
        {
            StringBuilder res = new StringBuilder();
            for (int counter = 0; counter < bytes.Length; counter++)
            {
                res.Append(string.Format("{0:x2}", bytes[counter]));
            }
            return res.ToString();
        }

        public static string Encrypt(string password)
        {
            using var md5 = System.Security.Cryptography.MD5.Create();
            byte[] res = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BytesToHex(res);
        }
    }
}
