using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Keywords
    {
        [Key]
        public int KeywordId { get; set; }
        public string dbkeyskilltype { get; set; }
        public string dbkeyword { get; set; }
        public TiKeyword ti_keyword { get; set; }
    }
}