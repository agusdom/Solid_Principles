using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_I
{
    public interface IBasicActions<T>
    {
        public T Get(int id);
        public List<T> GetList();
        public void Add(T entity);
    }
}
