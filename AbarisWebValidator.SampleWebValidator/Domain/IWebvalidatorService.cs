using AbarisWebValidator.SampleWebValidator.Models;
using CoreWCF;
using CoreWCF.Web;
using System.Collections.Generic;

namespace AbarisWebValidator.SampleWebValidator.Domain
{
    [ServiceContract]
    public interface IWebvalidatorService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/getData_Banco?ID={id}")]
        public IEnumerable<IEnumerable<IndiceValor>> GetData_Banco(string id);
    }
}
