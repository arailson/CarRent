using CarRent.Data;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace CarRent.Validator
{
    public class StoreValidator
    {
        public bool ExistsName { get; set; }
        public bool ValidCnpj { get; set; }
        public bool ValidCep { get; set; }

        private string calculaDigitos(string digitos, int posicoes = 10, int somaDigitos = 0)
        {

            for (int i = 0; i < digitos.Length; i++)
            {
                somaDigitos = somaDigitos + (int)Char.GetNumericValue(digitos[i]) * posicoes;
                posicoes = posicoes - 1;

                if (posicoes < 2)
                {
                    posicoes = 9;
                }
            }

            somaDigitos = somaDigitos % 11;

            if (somaDigitos < 2)
            {
                somaDigitos = 0;
            }
            else
            {
                somaDigitos = 11 - somaDigitos;
            }

            var cnpj = digitos + somaDigitos;
            return cnpj;
        }
        public StoreValidator ValidateNome(string name)
        {
            this.ExistsName = StoreDbSingleton.Instance.DB_STORES.Any(s => s.Name.ToLower() == name.ToLower());
            return this;
        }

        public StoreValidator ValidateCnpj(string cnpj)
        {
            try
            {

                cnpj = Regex.Replace(cnpj, @"[^0-9]", "");

                var cnpjOriginal = cnpj;
                var primeirosNumerosCnpj = cnpj.Substring(0, 12);

                var calculo1 = calculaDigitos(primeirosNumerosCnpj, 5);
                var calculo2 = calculaDigitos(calculo1, 6);

                var confereCnpj = calculo2;


                this.ValidCnpj = cnpjOriginal == confereCnpj;
            }
            catch
            {
                this.ValidCnpj = false;
            }


            return this;
        }

        public StoreValidator ValidateCep(string cep)
        {
            this.ValidCep = Regex.Match(cep, "\\d{5}-?\\d{3}").Success;
            return this;
        }

        public bool isValid()
        {
            return !this.ExistsName && this.ValidCnpj && this.ValidCep;
        }
    }
}
