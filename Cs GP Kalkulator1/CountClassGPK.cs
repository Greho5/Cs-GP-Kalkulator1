using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_GP_Kalkulator1
{
    class CountClassGPK
    {
        private string[] tempTable;
        private string temp = "", number1= "", number2="",znak="";
        double result = 0;
        public string countFunction(string inputNumberGP)
        {
            temp = inputNumberGP;
            temp = temp.Replace("\n",String.Empty).Replace("\r", String.Empty).Replace("\t", String.Empty);
            Console.WriteLine(temp);
            Console.WriteLine("####");
            if (inputNumberGP.Contains("+"))
            {
                znak = "+";
                tempTable = temp.Split('+');
                number1 = tempTable[0];
                number2 = tempTable[1];
                result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            }
            else if (inputNumberGP.Contains("-"))
            {
                znak = "-";
                tempTable = temp.Split('-');
                number1 = tempTable[0];
                number2 = tempTable[1];
                result = Convert.ToDouble(number1) - Convert.ToDouble(number2);
            }
            else if (inputNumberGP.Contains("*"))
            {
                znak = "*";
                tempTable = temp.Split('*');
                number1 = tempTable[0];
                number2 = tempTable[1];
                result = Convert.ToDouble(number1) * Convert.ToDouble(number2);
            }
            else if (inputNumberGP.Contains("/"))
            {
                znak = "/";
                tempTable = temp.Split('/');
                number1 = tempTable[0];
                number2 = tempTable[1];
                result = Convert.ToDouble(number1) / Convert.ToDouble(number2);
            }
            Console.WriteLine(number1 +" _ "+ number2 +" _ "+ znak +" _ "+ result);
            return (number1 + Environment.NewLine + znak + Environment.NewLine + number2 + Environment.NewLine + result.ToString());
        }

    }
}
