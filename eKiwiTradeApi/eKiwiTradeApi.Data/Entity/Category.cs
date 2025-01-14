using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKiwiTradeApi.Data.Entity
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [Column("categoryid")]
        public int CategoryId { get; set; }

        [Column("categoryname")]
        public string CategoryName { get; set; }
    }
}
