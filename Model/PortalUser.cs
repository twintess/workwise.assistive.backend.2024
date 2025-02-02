using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workwise.assistive.backend.Model
{
    public class PortalUser
    {
        [Key]
        [ForeignKey("Id")]
        public IdentityUser? User { get; set; }
        public string? Name { get; set; }
    }
}
