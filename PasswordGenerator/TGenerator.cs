using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class TGenerator
    {
        private string spassphrase;

        private static TGenerator newPassphrase = new TGenerator();

        private TGenerator()
        {

        }

        public static TGenerator getInstance()
        {
            return newPassphrase;
        }


        public void generateString(int lenght = 8)
       {
           string ret = string.Empty;
           System.Text.StringBuilder SB = new System.Text.StringBuilder();
           string Content = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw!öäüÖÄÜß\"§$%&/()=?*#-";
           Random rnd = new Random();
           for (int i = 0; i < lenght; i++)
                {
                   SB.Append(Content[rnd.Next(Content.Length)]);
                }
            SPassphrase = SB.ToString();

       }
        
        
        public string SPassphrase
        {
            get { return spassphrase; }
            set { spassphrase = value; }
        }


       
            
    }

}
