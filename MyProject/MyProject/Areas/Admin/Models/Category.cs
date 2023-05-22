using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Areas.Admin.Models
{
    public class Category
    {
        [Key]
        public int IDCategory { get; set; }
        [DisplayName("نام دسته")]
        public string TitleCategory { get; set; }
        public virtual ICollection<News> News { get; set; }

    }
}
