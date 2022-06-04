using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeAPP
{
    class MorseDict_International
    {
        string[,] internation_dict = new string[,] {
                { "a", ".-" },
                { "b", "-..." },
                {"c", "-.-." },
                {"d", "-.." },
                {"e", "." },
                {"f", "..-." },
                {"g", "--." },
                {"h", "...." },
                {"i", ".." },
                {"j", ".---" },
                {"k", "-.-" },
                {"l", ".-.." },
                {"m", "--" },
                {"n", "-." },
                {"o", "---" },
                {"p", ".--." },
                {"q", "--.-" },
                {"r", ".-." },
                {"s", "..." },
                {"t", "-" },
                {"u", "..-" },
                {"v", "...-" },
                {"w", ".--" },
                {"x", "-..-" },
                {"y", "-.--" },
                {"z", "--.." },
                {"1", ".----" },
                {"2", "..---" },
                {"3", "...--" },
                {"4", "....-" },
                {"5", "....." },
                {"6", "-...." },
                {"7", "--..." },
                {"8", "---.." },
                {"9", "----." },
                {"0", "-----" },
                {" ", "   " }
            };
        public string getmorsecode(string letter)
        {
            string output = "#";
            for (int i = 0; i < internation_dict.GetLength(0); i++)
            {
                if (letter == internation_dict[i, 0])
                {
                    output = internation_dict[i, 1];
                    break;
                };
            }
            return output;
        }

        public string getletter(string morsecode)
        {
            string output = "#";
            for (int i = 0; i < internation_dict.GetLength(0); i++)
            {
                if (morsecode == internation_dict[i, 1])
                {
                    output = internation_dict[i, 0];
                    break;
                }
            }
            return output;
        }
    }
}
