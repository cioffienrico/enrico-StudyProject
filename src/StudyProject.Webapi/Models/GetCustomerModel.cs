using System;
using System.ComponentModel.DataAnnotations;

namespace StudyProject.Webapi.Models
{
    public class GetCustomerModel
    {

        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public GetCustomerModel(string fullName, DateTime birthday, string rg, string cpf, string cep, string rua, string numero, string complemento, string bairro, string cidade, string estado)
        {
            FullName = fullName;
            Birthday = birthday;
            Rg = rg;
            Cpf = cpf;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

    }
}
