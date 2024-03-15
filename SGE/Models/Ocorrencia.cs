using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class Ocorrencia
    {
        public Guid OcorrenciaId { get; set; }
        public Guid TipoOcorrenciaId { get; set; }


        [Display(Name = "Tipo de Ocorrência")]
        public TipoOcorrencia? TipoOcorrencia { get; set; }
        public Guid UsuarioId { get; set; }

        [Display(Name = "Aluno")]
        public Usuario? Usuario { get; set; }
        public Guid AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

        [Display(Name = "Data da Ocorrência")]
        public DateTime DataOcorrencia { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Cad. Ativo")]
        public bool CadAtivo { get; set; }

        [Display(Name = "Cad. Inativo")]
        public DateTime? CadInativo { get; set; }
        public bool Finalizado { get; set; }

        [Display(Name = "Data Finalização")]
        public DateTime? DataFinalizado { get; set; }
        public string? Tratativa { get; set; }
    }
}
