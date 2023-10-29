using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class StringList
    {
        private string[] _stringlist;
        public StringList()
        {
            _stringlist = Array.Empty<string>();
        }

        public void Add(string item)
        {
            Array.Resize(ref _stringlist, _stringlist.Length+1);
            _stringlist[^1] = item;
        }

        public void GettAll()
        {
            foreach(string item in _stringlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
