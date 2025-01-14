using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKiwiTradeApi.Data.Entity
{
    [Table("Type")]
    public class TypeEntity
    {
        [Key]
        [Column("typeid")]
        public int TypeId { get; set; }
        
        [Column("typename")]
        public required string TypeName { get; set; }
        
        [Column("groupid")]
        public int GroupId { get; set; }
        
        [ForeignKey("groupid")]
        public virtual required GroupEntity Group { get; set; }
        
        [Column("categoryid")]
        public int CategoryId { get; set; }
        
        [ForeignKey("categoryid")]
        public virtual required Category Category { get; set; }
    }
}