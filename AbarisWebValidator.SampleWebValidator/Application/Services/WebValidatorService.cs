using AbarisWebValidator.SampleWebValidator.Domain;
using AbarisWebValidator.SampleWebValidator.Models;
using System;
using System.Collections.Generic;

namespace AbarisWebValidator.SampleWebValidator.Application.Services
{
    public class WebValidatorService : IWebvalidatorService
    {
        public List<List<IndiceValor>> GetData_Banco(string id)
        {
            var arrayOfIndices = new List<List<IndiceValor>>();

            for (var i = 0; i < 10; i++)
            {
                arrayOfIndices.Add(new List<IndiceValor>()
                {
                    new IndiceValor() { indice = "Matrícula", valor = id },
                    new IndiceValor() { indice = "CPF", valor = GenerateRandomCpf() },
                    new IndiceValor() { indice = "Nome", valor = GenerateRandomName(6) },
                    new IndiceValor() { indice = "Estado", valor = i % 2 == 0 ? "Minas Gerais":"São Paulo" }
                });
            }

            return arrayOfIndices;
        }

        private static string GenerateRandomCpf()
        {
            var random = new Random();

            return $"{random.Next(100, 999)}{random.Next(100, 999)}{random.Next(100, 999)}{random.Next(10, 99)}";
        }

        private static string GenerateRandomName(int length)
        {
            var random = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "ss", "t", "v", "w", "x", "z", "ç", "th" };
            string[] vowels = { "a", "e", "i", "o", "u", "io", "y" };
            var iterator = 2;
            string Name = "";
            Name += consonants[random.Next(consonants.Length)].ToUpper();
            Name += vowels[random.Next(vowels.Length)]; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (iterator < length)
            {
                Name += consonants[random.Next(consonants.Length)];
                iterator++;

                Name += vowels[random.Next(vowels.Length)];
                iterator++;
            }

            return Name;
        }
    }
}
