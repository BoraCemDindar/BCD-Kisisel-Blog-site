using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Core
{
    public class Category : EntityBase
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<BlogPost> BlogPosts { get; set; }
    }

}