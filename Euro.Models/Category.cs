using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Euro.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Nazwa Kategorii")]
        public string Name { get; set; }
        [DisplayName("#")]
        [Range(1, 100, ErrorMessage = "Podaj # między 1-100")]
        public int DisplayOrder { get; set; }
    }
}
