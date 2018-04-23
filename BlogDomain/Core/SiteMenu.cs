using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Core
{
    public class SiteMenu : EntityBase
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string cssClass { get; set; }
    }
}
