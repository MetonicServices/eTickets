﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? UserId { get; set; }
        [ForeignKey(nameof(User))]
        public IdentityUser? User { get; set; } 

        public List<OrderItem>? OrderItems { get; set; }

    }
}
