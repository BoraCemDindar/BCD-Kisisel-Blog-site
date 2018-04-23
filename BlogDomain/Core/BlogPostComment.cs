using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Core
{
    public class BlogPostComment : EntityBase
    {

        public string Name { get; set; }

        public string EMail { get; set; }

        public string Content { get; set; }

        private bool _isActive = false;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }

        public int BlogPostID { get; set; }

        [ForeignKey("BlogPostID")]
        public virtual BlogPost BlogPost { get; set; }
    }
}
