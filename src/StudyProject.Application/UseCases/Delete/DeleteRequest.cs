using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Application.UseCases.Delete
{
    public class DeleteRequest
    { 
        public bool Ativo { get; private set; }
        public Guid Id { get; private set; }
        public DeleteRequest(bool ativo, Guid id)
        {
            Ativo = ativo;
            Id = id;
        }
    }
}
