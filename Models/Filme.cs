using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace houseofCrimes.Models
{
    [Table("Filme")]
    public class Filme
    {
        [Column("FilmeId")]
        [Display(Name = "FilmeId")]
        public int FilmeId { get; set; }

        [Column("FilmeTitulo")]
        [Display(Name = "FilmeTitulo")]
        public string Titulo { get; set; }

        [Column("FilmeDescricao")]
        [Display(Name = "FilmeDescricao")]
        public string Descricao { get; set; }

        [Column("FilmeClassificacao")]
        [Display(Name = "FilmeClassificacao")]
        public string Classificacao { get; set; }

        [Column("FilmeTipo")]
        [Display(Name = "FilmeTipo")]
        public string Tipo { get; set; }

        [Column("FilmeDuracao")]
        [Display(Name = "FilmeDuracao")]
        public string Duracao { get; set; }
    }
}