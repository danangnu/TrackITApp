using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("ti_keyword")]
    public class TiKeyword
    {
        public int Id { get; set; }
        public Keywords Keywords { get; set; }
         [ForeignKey("Keywords")]
        public int idkeyword { get; set; }
        public bool quickkeyword { get; set; }
    }
}