using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [StringLength(100, ErrorMessage = "Category name is required")]
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
