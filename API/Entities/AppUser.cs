using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        [Key]
        public string dbstffid { get; set; }
        public string dbstffpswd { get; set; }
    }
}