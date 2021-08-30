using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace tiendajuegos.Models
{
 [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]       

        public int Id { get; set; }
        public string name{get; set;}
        public string category{get; set;}
        public int price{get; set;}
        public string desc{get; set;}
        
      
    }
}