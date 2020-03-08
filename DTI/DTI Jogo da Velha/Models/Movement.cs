using System;
using System.ComponentModel.DataAnnotations;

namespace GameAPI.Models
{
    public class Movement
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public char player { get; set; }

        [Required]
        public Position position { get; set; }

    }
}