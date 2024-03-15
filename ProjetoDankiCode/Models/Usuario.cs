using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoDankiCode.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "UserId")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Usuário")]
        [Column("Nome")]
        public string Nome { get; set; } = string.Empty;
    }
}
