using System;
using System.ComponentModel.DataAnnotations;

namespace GameAPI.Models
{
    public class Position
    {
        [Key]
        public Guid id { get; set; }
        public Guid GameID {get;set;}
        public int x { get; set; }
        public int y { get; set; }
        public char player { get; set; }
    }
}