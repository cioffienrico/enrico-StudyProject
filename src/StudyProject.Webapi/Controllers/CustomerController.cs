using Microsoft.AspNetCore.Mvc;
using StudyProject.Application.UseCases.Add;
using StudyProject.Application.UseCases.GetAll;
using StudyProject.Application.UseCases.GetById;
using StudyProject.Application.UseCases.Update;
using StudyProject.Webapi.Models;
using System;
using System.Collections.Generic;

namespace StudyProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IAddUseCase addUseCase;
        private readonly IGetAllUseCase getAllUseCase;
        private readonly IGetByIdUseCase getByIdUseCase;
        private readonly UpdateUseCase updateUseCase;
        public CustomerController(IAddUseCase addUseCase, IGetAllUseCase getAllUseCase, IGetByIdUseCase getByIdUseCase, UpdateUseCase updateUseCase)
        {
            this.addUseCase = addUseCase;
            this.getAllUseCase = getAllUseCase;
            this.getByIdUseCase = getByIdUseCase;
            this.updateUseCase = updateUseCase;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Guid), 200)]
        [Route("Add")]
        public IActionResult AddCustomer([FromBody] AddCustomerModel input)
        {
            var request = new AddRequest(input.FullName,
                input.Birthday,
                input.Rg,
                input.Cpf,
                input.Cep,
                input.Rua,
                input.Numero,
                input.Complemento,
                input.Bairro,
                input.Cidade,
                input.Estado);

            addUseCase.Execute(request);

            if (request.Erros.Count > 0)
                return BadRequest(request.Erros);

            return Ok(request.Customer.Id);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<GetCustomerModel>), 200)]
        [Route("GetAll")]

        public IActionResult GetAllCustomer()
        {
            var customers = getAllUseCase.Execute();
            var customerModel = new List<GetCustomerModel>();

            for (int i = 0; i < customers.Count; i++)
            {
                customerModel.Add(new GetCustomerModel(customerModel[i].FullName, customerModel[i].Birthday, customerModel[i].Rg, customerModel[i].Cpf, customerModel[i].Cep, customerModel[i].Rua, customerModel[i].Numero, customerModel[i].Complemento, customerModel[i].Bairro, customerModel[i].Cidade, customerModel[i].Estado));
            }
            return Ok(customerModel);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Guid), 200)]
        [Route("GetById")]
        public IActionResult GetByIdCustomer([FromBody] GetCustomerIdInput input)
        {                     
            var customer = getByIdUseCase.Execute(new GetByIdRequest(input.CustomerId));

            var customerModel = new GetCustomerModel(customer.FullName, customer.Birthday, customer.Rg, customer.Cpf, customer.Endereco.Cep, customer.Endereco.Rua, customer.Endereco.Numero, customer.Endereco.Complemento, customer.Endereco.Bairro, customer.Endereco.Cidade, customer.Endereco.Estado);

            return Ok(customerModel);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Guid), 200)]
        [Route("Update")]
        public IActionResult UpdateCustomer([FromBody] GetCustomerIdInput input)
        {
            var customer = getByIdUseCase.Execute(new GetByIdRequest(input.CustomerId));

            var customerModel = updateUseCase.Execute(new UpdateRequest(customer.Id, customer.FullName, customer.Birthday, customer.Rg, customer.Cpf, customer.Endereco.Cep, customer.Endereco.Rua, customer.Endereco.Numero, customer.Endereco.Complemento, customer.Endereco.Bairro, customer.Endereco.Cidade, customer.Endereco.Estado));

            return Ok(customerModel);
        }

    }
}
