using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCodeFirst.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome do usuário é obrigatório")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O email do usuário é obrigatório")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
    }
}
