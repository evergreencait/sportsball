using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsBall.Models
{
    [Table("Divisions")]
    public class Division
    {
        public Division()
        {
            this.Teams = new HashSet<Team>();
        }

        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public int Max { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

    }
}
