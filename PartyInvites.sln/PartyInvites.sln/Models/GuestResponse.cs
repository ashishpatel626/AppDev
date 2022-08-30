using System.ComponentModel.DataAnnotations;

namespace PartyInvites.sln.Models
{
  public class GuestResponse
  {
    [Required(ErrorMessage = "Please enter your name")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Please enter your phone number")]
    [Phone]
    [StringLength(maximumLength:10, ErrorMessage = "Please enter a Valid Phone Number", MinimumLength = 10)]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Please specify whether you'll attend")]
    
    public bool? WillAttend { get; set; }
  }
}
