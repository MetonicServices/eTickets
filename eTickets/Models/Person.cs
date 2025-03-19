using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First Name must be between 1 and 50 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Last Name must be between 1 and 100 characters")]
        public string? LastName { get; set; }
    }
}
