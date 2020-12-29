using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Models
{
    public class Category
    {
        [Key]
        public int Categoryid { get; set; }
        [Required,Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }
        [Required, DefaultValue(1)]
        public int Status { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
        // muốn để null hoặc không xác định kiểu dữ liệu thì dùng dấu ?
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }

    }
}
