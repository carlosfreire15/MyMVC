using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVC.Models
{
    public class Usuario
    {
        [Range(1,100, ErrorMessage = "O código precisa ser de 1 a 100.")]
        public int Codigo { get; set; }
        [StringLength(15, MinimumLength = 3, ErrorMessage ="O nome deve ter entre 3 e 15 letras")]
        public string Nome { get; set; }
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Insira de 5 a 20 caracteres")]
        public string Descricao { get; set; }
        [Range(1, 100, ErrorMessage = "O peso precisa ser de 1 a 100 e conter os decimos. EX: 10.00.")]
        public int Peso { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Insira de 2 a 20 caracteres")]
        public string Categoria { get; set; }
        [Range(1, 100, ErrorMessage = "O peso precisa ser de 1 a 100 e conter os decimos. EX: 10.00.")]
        public int Valorunitario { get; set; }
    }
}