using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace houseofCrimes.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Column("CadastroId")] [Key]
        [Display(Name = "CadastroId")]
        public int CadastroId { get; set; }

        [Column("CadastroNome")]
        [Display(Name = "CadastroNome")]
        public string Nome { get; set; }

        [Column("CadastroSobrenome")]
        [Display(Name = "CadastroSobrenome")]
        public string Sobrenome { get; set; }

        [Column("CadastroDtNascimento")]
        [Display(Name = "CadastroDtNascimento")]
        public string DtNascimento { get; set; }

        [Column("CadastroEmail")]
        [Display(Name = "CadastroEmail")]
        public string Email { get; set; }

        [Column("Nickname")]
        [Display(Name = "Nickname")]
        public string Nickname { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Column("CadastroTelefone")]
        [Display(Name = "CadastroTelefone")]
        public string Telefone { get; set; }

        [Column("CadastroTipo")]
        [Display(Name = "CadastroTipo")]
        public string Tipo { get; set; }
    }
}