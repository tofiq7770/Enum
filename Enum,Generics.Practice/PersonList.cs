using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class PersonList
    {
        private Person[] _personlist;
        public PersonList()
        {
            _personlist = Array.Empty<Person>();    
        }

        public void Add(Person item)
        {
            Array.Resize(ref _personlist,_personlist.Length+1);
            _personlist[^1] = item;
        }

        public void GetAll()
        {
            foreach(Person item in _personlist)
            {
                Console.WriteLine($"{item.Name} - {item.Surname}");
                    
            }
        }
    }
}
