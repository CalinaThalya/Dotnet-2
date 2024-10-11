using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_vendedores")]
    public class VendedorEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Nome { get; set; } // Remover = null! para teste

        [Required]
        [EmailAddress]
        public required string Email { get; set; } // Remover = null! para teste

        [Required]
        public required string Telefone { get; set; } // Remover = null! para teste

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public required string Endereco { get; set; } // Remover = null! para teste

        [Required]
        public DateTime DataContratacao { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal ComissaoPercentual { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal MetaMensal { get; set; }

        [Required]
        public DateTime CriadoEm { get; set; } = DateTime.UtcNow; // Usar UTC
    }

}
