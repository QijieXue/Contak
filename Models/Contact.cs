using System.ComponentModel.DataAnnotations;

namespace Contak.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FamilyName { get; set; }        
        public string Phone { get; set; }
        public string Address { get; set; }
        public string WeChatId { get; set; }
        public string Email { get; set; }
        [MaxLength(500)]
        public string Description { get; set; } 
    }
}