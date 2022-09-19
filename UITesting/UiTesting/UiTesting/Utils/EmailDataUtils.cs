using System;
using System.Collections.Generic;
using System.Text;

namespace UiTesting.Utils
{
    public static class EmailDataUtils
    {
        private static Random rm = new Random();
        
        public static string RandomPassword()
        {
            String[] numbers = { "0", "1", "2", "3", "4", "5"};
            String[] letters = { "a", "f", "r", "u", "k"};
            String[] lettersCap = { "B", "C", "D", "E", "G"};
            String[] specialChars = { "!", "@", "#", "$", "%" };
            string password = "";
            int i = 0;
            
            while (i < 3)
            {
                int random_num = rm.Next(0, 4);
                password += letters[random_num];
                password += numbers[random_num];
                password += lettersCap[random_num];
                password += specialChars[random_num];
                i++;
            }

            return password;
        }
        
        public static string RandomEmailAddress()
        {
            String[] letters = { "a", "f", "r", "u", "k" };
            String[] lettersCap = { "B", "C", "D", "E", "G" };

            string emailAddress = "";

            for (int i = 0; i < 5; i++)
            {
                int randromNumber = rm.Next(0, 4);
                emailAddress += letters[randromNumber];
                emailAddress += lettersCap[randromNumber];
            }
            return emailAddress;
        }
        
        public static string RandomEmailDomain()
        {
            String[] domains = { "gmail", "yahoo", "hotmail", "aol", "msn", "wanadoo", "comcast" };
            string randomEmailDomain = "@";
            int randomNumber = rm.Next(0, 6);
            randomEmailDomain += domains[randomNumber];
            return randomEmailDomain;
        }
        
        public static string RandomEmailDomainEnding()
        {
            int randomIndex = rm.Next(1, 10);
            return randomIndex.ToString();
        }
    }
}
