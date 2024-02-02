using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{   
    //internal trabaja en el mismo ensamblado
    //como son dos proyectos en uno podemos tener problemas entoncees se pone PUBLIC class
    public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandID { get; set; }
        public string Name { get; set; }

    }
}
