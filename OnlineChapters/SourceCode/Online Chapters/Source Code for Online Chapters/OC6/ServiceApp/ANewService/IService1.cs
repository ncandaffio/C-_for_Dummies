using System.Runtime.Serialization;
using System.ServiceModel;

namespace ANewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to 
    // change the interface name "IService1" in both code and config file 
    // together.
    [ServiceContract]
    public interface TheService
    {
        [OperationContract]
        int DoAdd(int Value1, int Value2);

        [OperationContract]
        ResultType DoAddUsingDataContract(InputType composite);
    }

    // Use a data contract as illustrated in the sample below to add 
    // composite types to service operations.

    // You can add XSD files into the project. After building the project,
    // you can directly use the data types defined there, with the 
    // namespace "ANewService.ContractType".
    [DataContract]
    public class InputType
    {
        int Value1 = 1;
        int Value2 = 2;

        [DataMember]
        public int Value1Value
        {
            get { return Value1; }
            set { Value1 = value; }
        }

        [DataMember]
        public int Value2Value
        {
            get { return Value2; }
            set { Value2 = value; }
        }
    }

    [DataContract]
    public class ResultType
    {
        int Result = 0;

        [DataMember]
        public int ResultValue
        {
            get { return Result; }
            set { Result = value; }
        }
    }
}
