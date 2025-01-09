using GeekShopping.OrderAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.OrderApi.Model
{
    [Table("order_detail")]
    public class OrderDetail : BaseEntity
    {
        public long OrderHeaderId { get; set; }

        [ForeignKey("OrderHeaderId")]
        public virtual OrderHeader OrderHeader { get; set; }

        [Column("ProductId")]
        public long ProductId { get; set; }

        [Column("count")]
        public int Count { get; set; }

        [Column("Product_Name")]
        public string ProductName { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

    }
}
