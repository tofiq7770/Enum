using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Repository<T> where T : BaseEntity
    {
        private T[] _datas;
        public Repository()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[^1] = item;
        }

        public void GetAll()
        {
            foreach (T item in _datas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
