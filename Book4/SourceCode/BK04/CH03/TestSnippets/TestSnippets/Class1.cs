using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSnippets
{
    public class Class1
    {
        public string FirstName { get; set; }

        public void TestMethod()
        {
            try
            {
                for (int count = 1; count <= 10; count++)
                {
                    Console.WriteLine(string.Format("The number is {0}.", count));
                }
            }
            catch (Exception)
            {
                 throw;
            }
        }
    }
}
