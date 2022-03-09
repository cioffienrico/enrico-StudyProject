using StudyProject.Application.Repositories;
using StudyProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Application.UseCases.Update
{
    public class UpdateUseCase : IUpdateUseCase
    {
        private readonly ICustomerRepository customerRepository;

        public UpdateUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public bool Execute(UpdateRequest request)
        {
            var customer = customerRepository.BuscarPorId(request.Id);

            if (customer == null)
                return false;

            var customerUpdate = new Customer(customer.Id, request.FullName, request.Birthday, request.Rg, request.Cpf, customer.RegisterDate, customer.Endereco, customer.Ativo);

            var updated = customerRepository.AtualizarCliente(customerUpdate);

            return updated;
        }
    }
}
