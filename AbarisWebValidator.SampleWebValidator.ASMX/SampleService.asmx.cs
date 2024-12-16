using AbarisWebValidator.SampleWebValidator.Application.Services;
using AbarisWebValidator.SampleWebValidator.Domain;
using AbarisWebValidator.SampleWebValidator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;

namespace AbarisWebValidator.SampleWebValidator.ASMX
{
    /// <summary>
    /// Summary description for SampleService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [ScriptService]
    public class SampleService : WebService
    {
        private readonly IWebvalidatorService validatorService;

        public SampleService()
            => validatorService = new WebValidatorService();

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public List<List<IndiceValor>> GetData_Banco(string id)
            => validatorService.GetData_Banco(id).ToList();
    }
}
