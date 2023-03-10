using System.ComponentModel.DataAnnotations;

namespace aspWebApiCore.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(280)]
        public string DescricionCorta { get; set; } = string.Empty;
        public string DescricionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public int Nivel { get; set; }

    }
}
