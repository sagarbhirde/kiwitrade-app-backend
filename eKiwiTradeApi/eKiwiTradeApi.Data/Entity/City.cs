using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKiwiTradeApi.Data.Entity
{
    [Table("City")]
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cityid")]
        public int CityId { get; set; }

        [Column("distid")]
        public int DistId { get; set; }

        [Column("cityname")]
        [MaxLength(100)]
        public required string CityName { get; set; }
    }
}