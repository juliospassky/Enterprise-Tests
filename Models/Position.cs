using System.ComponentModel.DataAnnotations;

namespace GameAPI.Models
{
    public class Position {
        [Key]
        public int id {get;set;}        
        public int x {get; set;}
        public int y {get; set;}
    }
}