using System.ComponentModel.DataAnnotations;
namespace SimAPI.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set;}
        public int Age { get; set;}
        public string UserName { get; set;}
        public string FullName { get; set; }
        public string Address { get; set;}
    }
}