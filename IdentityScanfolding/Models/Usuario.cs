using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityScanfolding
{
    public class Usuario : IdentityUser<Guid>
    {
        [MaxLength(128)]
        public string NomeCompleto { get; set; } = ""; // resolve o problema do cadastro automatico.

        public string CPF { get; set; } = "";
    }

}