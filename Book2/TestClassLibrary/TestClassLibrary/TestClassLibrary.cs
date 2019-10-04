using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class DoMath
    {
        public int DoAdd(int Num1, int Num2)
        /// Adds two numbers
        {

            return Num1 + Num2;
        }

        public int DoSub(int Num1, int Num2)
        {
            /// Subtracts two numbers
            return Num1 - Num2;
        }

        public int DoMul(int Num1, int Num2)
        {
            // Multiplies two numbers
            return Num1 * Num2;
        }

        public int DoDiv(int Num1, int Num2)
        {
            /// Devides two numbers
            return Num1 / Num2;
        }
    }
}
