using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Veritas.Models
{
    public class ProfileImage
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        public decimal UserId { get; set; }
        public string ImagePath { get; set; }
    }
}