using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }
        [Required(ErrorMessage = "O campo Data de início é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]
        public DateOnly? DataInicio { get; set; }
        [Required(ErrorMessage = "O campo Data de finalização é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A Data Informada não é Válida")]
        public DateOnly? DataFim { get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 100 caracteres")]
        public string? Descricao { get; set; }
        [Required(ErrorMessage = "O campo Sigla é obrigatório")]
        [MaxLength(15, ErrorMessage = "A Sigla deve ter no máximo 15 caracteres")]
        public string? Sigla { get; set; }

        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }


    }
}
