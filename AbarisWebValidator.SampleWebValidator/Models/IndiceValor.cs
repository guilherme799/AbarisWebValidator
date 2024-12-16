using System.Runtime.Serialization;

namespace AbarisWebValidator.SampleWebValidator.Models
{
    [DataContract]
    public class IndiceValor
    {
        [DataMember]
        public string indice { get; set; }
        [DataMember]
        public string valor { get; set; }
    }
}
