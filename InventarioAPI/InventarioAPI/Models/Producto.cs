using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioAPI.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name   { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string price { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string description { get; set; }

        public int stock { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string category { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string link { get; set; }
    }
}
