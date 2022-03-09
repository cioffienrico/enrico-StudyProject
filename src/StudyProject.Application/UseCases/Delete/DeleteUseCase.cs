using StudyProject.Application.Repositories;
using StudyProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Application.UseCases.Delete
{
    public class DeleteUseCase : IDeleteUseCase
    {
        private readonly ICustomerRepository customerRepository;

        public DeleteUseCase(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public bool Execute(DeleteRequest request)
        {
            var customer = customerRepository.BuscarPorId(request.Id);

            if (customer == null)
                return false;

            return true;
        }
    }
}
