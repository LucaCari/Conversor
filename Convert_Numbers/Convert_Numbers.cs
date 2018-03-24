using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Numbers
{
    class Convert_Numbers
    {
		//Classe para conversão 
        public string binaryNumber { get; set; }

        public string binaryToHex()
        {
            return Convert.ToInt32(binaryNumber, 2).ToString("X");
        }

        public string binaryToOctal()
        {
            return Convert.ToString(Convert.ToInt32(binaryNumber, 2),8);
        }

        public string binaryToDecimal()
        {
            return Convert.ToInt32(binaryNumber, 2).ToString();
        }

        public void setdecimalToBinary(int decimalNumber)
        {
            binaryNumber = Convert.ToString(decimalNumber,2);
        }

        public void setoctalToBinary(string octalNumber)
        {
            binaryNumber = Convert.ToString(Convert.ToInt32(octalNumber, 8), 2);
        }
        public void sethexToBinary(string hexNumber)
        {
            binaryNumber = String.Join(String.Empty, hexNumber.Select(c =>  Convert.ToString(Convert.ToUInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }





    }
}
