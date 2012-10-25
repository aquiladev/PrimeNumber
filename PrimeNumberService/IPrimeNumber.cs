using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrimeNumberService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPrimeNumber" in both code and config file together.
    [ServiceContract]
    public interface IPrimeNumber
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string[] GetPrimes();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string[] GetPrimesStartedAt(string beginSigns);
    }
}
