﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsBall.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Players { get; set; }
        public string Captain { get; set; }
        public int DivisionId { get; set; }

        public virtual Division Division { get; set;  }
    }
}