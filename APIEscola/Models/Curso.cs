using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }
        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [MaxLength(10, ErrorMessage = "A sigla deve ter no máximo 10 caracteres")]
        public string? Sigla { get; set; }
        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 100 caracteres")]
        public string? Descricao { get; set; }
    }
}
