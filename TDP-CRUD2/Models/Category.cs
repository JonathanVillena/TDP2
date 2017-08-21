using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TDP_CRUD2.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}