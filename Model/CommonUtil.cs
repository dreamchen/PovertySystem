using System;
using System.Text;
using System.Security.Cryptography;

namespace Model
{
    public class CommonUtil
    {

        public static string genericUUID()
        {
            string UUIDstr = "";
            string zfc = "qwertyuioplkjhgfdsazxcvbnm1234567890";
            Random rd = new Random();
            while (UUIDstr.Length < 32)
            {
                //随机产生一个数字，该数字是字符串zfc中的下标
                int index = rd.Next(0, zfc.Length);
                //从字符串zfc中把下标为index的字符截取出来
                string temp = zfc.Substring(index, 1);
                UUIDstr += temp;
            }
            return UUIDstr;
        }
        
        public static string genericGUID()
        {
            return System.Guid.NewGuid().ToString().Replace("-", "");
        }

        public static string encryptMD5(string str)
        {
            byte[] result = Encoding.Default.GetBytes(str);    //tbPass为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }

        public static string decryptMD5(string str)
        {
            byte[] result = Encoding.Default.GetBytes(str);    //tbPass为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }
    }
}
