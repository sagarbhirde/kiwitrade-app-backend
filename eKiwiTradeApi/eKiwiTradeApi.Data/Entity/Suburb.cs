using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKiwiTradeApi.Data.Entity
{
    [Table("Suburb")]
    public class Suburb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("suburbid")]
        public int SuburbId { get; set; }

        [Column("cityid")]
        public int CityId { get; set; }

        [Column("distid")]
        public int DistId { get; set; }

        [Column("suburbname")]
        public string SuburbName { get; set; }
    }
}
