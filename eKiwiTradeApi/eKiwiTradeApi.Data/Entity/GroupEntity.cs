using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKiwiTradeApi.Data.Entity
{
    [Table("Group")]
    public class GroupEntity
    {
        [Key]
        [Column("groupid")]
        public int GroupId { get; set; }

        [MaxLength(100)]
        [Column("groupname")]
        public string GroupName { get; set; }

        [Column("categoryid")]
        public int CategoryId { get; set; }

        [ForeignKey("categoryid")]
        public virtual required Category Category { get; set; }
    }
}