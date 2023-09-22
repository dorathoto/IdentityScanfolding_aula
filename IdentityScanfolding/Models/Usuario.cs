using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityScanfolding.Models
{
    public class Usuario : IdentityUser<Guid>
    {
        [MaxLength(128)]
        public string NomeCompleto { get; set; }

        public string CPF { get; set; }
    }

}