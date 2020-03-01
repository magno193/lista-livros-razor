using System.ComponentModel.DataAnnotations;

namespace lista_livros_razor.Models
{
    public class Livro {

        [Key]
        public int LivroId { get; set; }

        [Required]
        public string Nome { get; set; }
        
        public string Autor { get; set; }
    }
}