﻿using StudyProject.Domain;
using System;

namespace StudyProject.Test.Builders
{
    public class CustomerBuilder
    {
        public Guid Id;
        public string FullName;
        public DateTime Birthday;
        public string Rg;
        public string Cpf;
        public DateTime RegisterDate;
        public Endereco Endereco;
        public bool Ativo;

        public static CustomerBuilder New()
        {
            return new CustomerBuilder()
            {
                Id = Guid.NewGuid(),
                FullName = "Test project domain",
                Birthday = new DateTime(1990, 01, 01),
                Rg = "52238190X",
                Cpf = "47312337805",
                RegisterDate = DateTime.Today,
                Endereco = EnderecoBuilder.New().Build(),
                Ativo = true,
            };  
        }

        public CustomerBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public CustomerBuilder WithEndereco(Endereco endereco)
        {
            Endereco = endereco;
            return this;
        }

        public CustomerBuilder WithFullName(string fullName)
        {
            FullName = fullName;
            return this;
        }

        public CustomerBuilder WithBirthday(DateTime birthday)
        {
            Birthday = birthday;
            return this;
        }

        public CustomerBuilder WithRg(string rg)
        {
            Rg = rg;
            return this;
        }

        public CustomerBuilder WithCpf(string cpf)
        {
            Cpf = cpf;
            return this;
        }

        public CustomerBuilder WithRegisterDate(DateTime registerDate)
        {
            RegisterDate = registerDate;
            return this;
        }

        public Customer Build() => new Customer(Id, FullName, Birthday, Rg, Cpf, RegisterDate, Endereco, Ativo);
    }
}
