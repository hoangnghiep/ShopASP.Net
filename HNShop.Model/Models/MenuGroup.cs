using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HNShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự động tăng ở khóa chính
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}