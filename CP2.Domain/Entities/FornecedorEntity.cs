using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("tb_fornecedores")] // Nome da tabela corrigido
    public class FornecedorEntity
    {
        [Key] // Chave primária
        public int Id { get; set; }

        [Required] // Campo obrigatório
        public string Nome { get; set; } = null!;

        [Required] // Campo obrigatório
        [Column(TypeName = "varchar(14)")] // Tipo da coluna
        public string CNPJ { get; set; } = null!;

        [Required] // Campo obrigatório
        public string Endereco { get; set; } = null!;

        [Required] // Campo obrigatório
        public string Telefone { get; set; } = null!;

        [Required] // Campo obrigatório
        [EmailAddress] // Valida formato de email
        public string Email { get; set; } = null!;

        [Required] // Campo obrigatório
        public DateTime CriadoEm { get; set; } = DateTime.UtcNow; // Usando UTC para evitar problemas de fuso horário
    }
}

}
