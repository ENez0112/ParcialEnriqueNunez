using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiEnriqueNunez.Models
{
    /// <summary>
    /// alpha3Code string
    //  region string
    //  name string
    //  area int
    //  callingCodes clase nueva(lista, string)
    //  languages clase nueva(lista, string x4)
    //  flag link validar enlace
    /// </summary>
    /// 

    public class CallingCodes
    {
        [Key]
        [Required]
        public string CallingCode { get; set; }
    }

    public class Languages
    {
        [Key]
        [Required]
        public string Iso639_1 { get; set; }
        [Required]
        public string Iso639_2 { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string NativeName { get; set; }
    }


    public class Country
    {
        [Key]
        [Required]
        [StringLength(3, ErrorMessage = "EL CAMPO SOLO ACEPTA 3 LETRAS PARA EL CODIGO DEL PAIS", MinimumLength = 3)]
        public string Alpha3Code { get; set; }

        [Required]
        [StringLength(40)]
        public string Region { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, 18000000)]
        public int Area { get; set; }

        // NUEVAS CLASES Y OBJETOS
        [Required]
        public List<CallingCodes> CallingCodes { get; set; }

        [Required]
        public List<Languages> Languages { get; set; }

        [Required]
        [RegularExpression(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$")]
        public string Flag { get; set; }
    }
}