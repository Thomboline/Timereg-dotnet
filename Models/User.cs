
using System.ComponentModel.DataAnnotations;

namespace Vikarprojekt.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Hours { get; set; }
    }
}