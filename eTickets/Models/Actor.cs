﻿using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Profile Picture is required")]
        [Display(Name = "Profile Picture")]       
        public string? ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full Name must be between 3 and 50 characters")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        // Relationships
        public ICollection<Actor_Movie>? Actors_Movies { get; set; }

    }
}
