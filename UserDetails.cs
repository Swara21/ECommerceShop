﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Shoppingcart.Models
{
    public class UserDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        public string? Role { get; set; }

        public string? Name { get; set; }

        public string? Gender { get; set; }

        [DataType("varchar(30)")]
        [Required(ErrorMessage = "Email can not be empty")]
        public string? EmailId { get; set; }

        [Required(ErrorMessage = "Mobile no. can not be empty")]
        public string? MobileNumber { get; set; }

        [Required]
        public string? AddressInfo { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? UserState { get; set; }

        [Required]
        public string? Pincode { get; set; }

        [Required(ErrorMessage = "Password can not be empty")]
        public string? Password { get; set; }

        [NotMapped]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required]
        public bool IsLogin { get; set; } = false;
    }
}
