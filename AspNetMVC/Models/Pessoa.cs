using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [DisplayName("Nome da Pessoa")]
        [MaxLength(50, ErrorMessage = "O Nome poder ter no máximo 50 caracteres.")]
		[MinLength(5, ErrorMessage = "O Nome deve conter no mínimo 5 caracteres.")]
		public string Nome { get; set; }

        [DisplayName("Idade da Pessoa")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório")]
        [DisplayName("Endereço da Pessoa")]
		[MaxLength(200, ErrorMessage = "O Endereço pode ter no máximo 200 caracteres.")]
		public string Endereco { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório")]
		[MaxLength(80, ErrorMessage = "O E-mail pode ter no máximo 80 caracteres.")]
		[DataType(DataType.EmailAddress)]
		[DisplayName("E-mail da Pessoa")]
        public string Email { get; set; }

		public bool Ativo { get; set; }
	}
}