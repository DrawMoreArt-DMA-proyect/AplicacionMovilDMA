using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mx.edu.uttt.dma.appmovil.Entitades
{
    class Usuario
    {
        [Required]
        [StringLength(20)]
        public string UsuarioNombre { get; set; }
        [Required]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }
        [Required]
        [StringLength(100)]
        public string Contrasena { get; set; }
    }
}
