﻿using StudyProject.Domain.Validations;
using FluentValidation.Results;
using System;

namespace StudyProject.Domain
{
    public class Endereco
    {
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public string Cep { get; private set;}
        public string Rua{ get; private set; }
        public string Numero { get; private set; }
        public string Complemento{ get; private set; }
        public string Bairro{ get; private set; }
        public string Cidade{ get; private set; }
        public string Estado{ get; private set; }
        public ValidationResult Validations { get; set; }

        public Endereco(Guid id, Guid customerId, string cep, string rua, string numero, string complemento, string bairro, string cidade, string estado)
        {
            Id = id;
            CustomerId = customerId;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;

            Validations = new EnderecoValidation().Validate(this);
        }
    }
}
