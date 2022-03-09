using System;
using System.ComponentModel.DataAnnotations;

namespace StudyProject.Webapi.Models
{
    public class GetCustomerIdInput
    {
        [Required]
        public Guid CustomerId { get; set; }

    }
}
