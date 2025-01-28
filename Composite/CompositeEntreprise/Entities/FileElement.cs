using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite.Entities
{
    public  class FileElement : SystemFile
    {
        public FileElement(string name) : base(name)
        {
        }

        public override int GetCount()
        {
            return 1;
        }
    }
}
