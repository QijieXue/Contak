using System.ComponentModel.DataAnnotations;

namespace Contak.Dtos
{
    public class ContactCreateDto
    {
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