using AbarisWebValidator.SampleWebValidator.Models;
using CoreWCF;
using CoreWCF.Web;
using System.Collections.Generic;

namespace AbarisWebValidator.SampleWebValidator.Domain
{
    [ServiceContract]
    [ServiceKnownType(typeof(IndiceValor))]
    public interface IWebvalidatorService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/getData_Banco?ID={id}")]
        List<List<IndiceValor>> GetData_Banco(string id);
    }
}
