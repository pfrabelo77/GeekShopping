using GeekShopping.ProductApi.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductApi.Model
{
    [Table("Product")]
    public partial class Product : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("category_name")]
        public string CategoryName { get; set; }

        [Column("image_url")]
        public string ImageUrl { get; set; }

    }
}
