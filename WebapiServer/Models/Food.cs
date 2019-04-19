using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Food
    {
        [Key]
        public int Fid { get; set; }

        [StringLength(50)]
        public string FName { get; set; }
    }
}