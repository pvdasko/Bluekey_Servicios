namespace Servicios.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [Key]
        [StringLength(8)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(8)]
        public string Contrasena { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public int? Rol { get; set; }
    }
}
