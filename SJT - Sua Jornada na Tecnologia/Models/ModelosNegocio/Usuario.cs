using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SJT___Sua_Jornada_na_Tecnologia.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public ICollection<Jornada> Jornada { get; set; }
    }
}
