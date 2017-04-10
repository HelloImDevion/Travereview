using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travereview.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        
        [ForeignKey("Review")]
        public int ReviewID { get; set; }
        public virtual Review Review { get; set; }

    }
}