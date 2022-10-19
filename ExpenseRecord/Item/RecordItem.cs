using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ExpenseRecord.Item
{
    public class RecordItem
    {
        [Column("id")]
        public string? Id { get; set; }
         
        [Column("description")]
        [MaxLength(100)]
        public string? Description { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("date")]
        public DateTime? Date { get; set; }

        [Column("amount")]
        public string ? Amount { get; set; }
    }
}
