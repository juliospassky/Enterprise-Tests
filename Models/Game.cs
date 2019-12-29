using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameAPI.Models
{
    public class Game
    {
        [Key]
        public Guid Id { get; set; }

        public char firstPlayer { get; set; }

        public char turn { get; set; }
    }
}