using StudyProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Application.UseCases.Update
{
    public interface IUpdateUseCase
    {
        bool Execute(UpdateRequest request);

    }
}
