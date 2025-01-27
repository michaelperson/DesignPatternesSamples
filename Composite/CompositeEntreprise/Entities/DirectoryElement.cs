using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposite.Entities
{
    public class DirectoryElement : SystemFile
    {
        public DirectoryElement(string name) : base(name)
        {
        }

        public override int GetCount() => Elements.Sum(x => x.GetCount());
        //{
        //    return Elements.Sum(x => x.GetCount());
        //}

        public List<SystemFile> Elements = new();
        
        public void AddElement(SystemFile file)
        {
            Elements.Add(file);
        }

        public void RemoveElement(SystemFile file)
        {
            Elements.RemoveAll(x => x.Equals(file));
        }
    }
}
