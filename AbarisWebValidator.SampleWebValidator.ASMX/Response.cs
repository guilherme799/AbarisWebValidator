using AbarisWebValidator.SampleWebValidator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbarisWebValidator.SampleWebValidator.ASMX
{
    [Serializable]
    public class ArrayOfArrayOfIndiceValor
    {
        public List<ArrayOfIndiceValor> ArrayOfIndiceValor { get; set; }

        public ArrayOfArrayOfIndiceValor()
        {
            ArrayOfIndiceValor = new List<ArrayOfIndiceValor>();
        }

        public ArrayOfArrayOfIndiceValor AddIndiceValorRange(IEnumerable<IndiceValor> indiceValores)
        {
            ArrayOfIndiceValor.Add(new ArrayOfIndiceValor(indiceValores));

            return this;
        }
    }

    [Serializable]
    public class ArrayOfIndiceValor
    {
        public List<IndiceValor> IndiceValor { get; set; }

        public ArrayOfIndiceValor()
        {
            IndiceValor = new List<IndiceValor>();
        }

        public ArrayOfIndiceValor(IEnumerable<IndiceValor> indiceValores)
        {
            IndiceValor.AddRange(indiceValores);
        }
    }
}