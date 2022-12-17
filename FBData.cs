using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;

namespace FBLeague.Models
{

    public class FBData
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchID { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public string Status { get; set; }
        public string WinningTeam { get; set; }
        public int Points { get; set; }
    }
}