using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_smk_nusantara_2017
{
    public static class Utils
    {
        public static string generateRandomString(int len)
        {
            string stringTemp = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            string result = "";
            Random ran = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = ran.Next(stringTemp.Length);
                result += stringTemp[index];
            }
            return result;
        }

        public static string generateIdFor(string prefix)
        {
            return prefix +"-"+ generateRandomString(8);
        }
    }
}
