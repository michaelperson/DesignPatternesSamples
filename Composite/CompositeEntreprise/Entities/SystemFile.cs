using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite.Entities
{
    public abstract class SystemFile
    {
        public string Name { get; set; }

        public SystemFile(string name)
        {
            Name = name;
        }

        public abstract int GetCount();
    }
}
