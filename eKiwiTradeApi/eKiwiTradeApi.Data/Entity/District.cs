using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKiwiTradeApi.Data.Entity
{
    [Table("District")]
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("distid")]
        public int DistId { get; set; }

        [Column("distname")]
        public string DistName { get; set; }
    }
}
