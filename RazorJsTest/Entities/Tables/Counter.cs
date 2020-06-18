using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorJsTest.Entities.Tables
{
    [Table("counters")]
    public class Counter
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("key")]
        public long Key { get; set; }

        [Column("value")]
        public long Value { get; set; }
    }
}
