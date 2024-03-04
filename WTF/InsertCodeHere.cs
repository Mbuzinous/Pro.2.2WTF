using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace WTF
{
    public class InsertCodeHere
    {
        private int return3;
        private int return4;
        private int return5;
        private int return10;
        private int return11;
        private int return20;
        private int return21;
        private int return22;
        private int return23;
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            MysticNumbers mysticNumbers = new MysticNumbers();

            return3 = mysticNumbers.ThreeNumbers(1, 2, 3); //returns 3
            return4 = mysticNumbers.ThreeNumbers(3, 4, 1); //returns 4
            return5 = mysticNumbers.ThreeNumbers(5, 4, 3); //returns 5

            return10 = mysticNumbers.TwoNumbers(10, 9); //returns 10
            return11 = mysticNumbers.TwoNumbers(10, 11); //returns 

            return20 = mysticNumbers.FourNumbers(20, 10, 9, 8); //returns 20
            return21 = mysticNumbers.FourNumbers(10, 21, 9, 8); //returns 21
            return22 = mysticNumbers.FourNumbers(20, 10, 22, 8); //returns 22
            return23 = mysticNumbers.FourNumbers(20, 10, 9, 23); //returns 23
        }
        public override string ToString()
        {
            return $"This is return3 {return3}, This is return4 {return4}, This is return5 {return5}\n\nThis is return10 {return10}, This is return11 {return11}\nThis is return20 {return20}, This is return21 {return21}, This is return22 {return22}, This is return23 {return23}\n";
        }
        // The LAST line of code should be ABOVE this line
    }
}
