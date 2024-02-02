using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BeerID {  get; set; }
        public string BeerName { get; set;}
        public int BrandID { get; set; }

        //para que la base de datos cree una llave foranea tiene que crear un objeto del tipo Brand
        //para indicarle que uno de los 3 campos de arriba se una al campo de abajo tenemos que hacer lo siguiente
        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }

    }
}
