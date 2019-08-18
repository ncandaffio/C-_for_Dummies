using System;

namespace ANewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to
    // change the class name "Service1" in both code and config file
    // together.
    public class Service1 : TheService
    {
        public int DoAdd(int Value1, int Value2)
        {
            return Value1 + Value2;
        }

        public ResultType DoAddUsingDataContract(InputType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }

            ResultType result = new ResultType();

            result.ResultValue = composite.Value1Value + 
                composite.Value2Value;

            return result;
        }
    }
}
