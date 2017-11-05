using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NAC.Models
{
    public class Nota
    {
        [Display(Name = "Nome")]
        [StringLength(100,ErrorMessage = "Nome deve ter até 100 caracteres")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Nome é obrigatorio")]
        public string Nome { get; set; }

        [Display(Name = "RM")]
        [Range(00001,99999,ErrorMessage = "Rm deve estar entre 1 e 99999")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Rm é obrigatorio")]
        public int Rm { get; set; }

        [Display(Name = "NAC")]
        [Range(0,10,ErrorMessage = "Nac deve estar entre 0 e 10")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Nac é obrigatorio")]
        public double Nac { get; set; }

        [Display(Name = "AM")]
        [Range(0, 10, ErrorMessage = "Am deve estar entre 0 e 10")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Am é obrigatorio")]
        public double Am { get; set; }

        [Display(Name = "PS")]
        [Range(0, 10, ErrorMessage = "Ps deve estar entre 0 e 10")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ps é obrigatorio")]
        public double Ps { get; set; }

        public double NotaFinal { get; set; }
    }
}