using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_I
{
    public class UserService : IBasicActions<User>,IEditableActions<User>
    {
        public void Add(User entity)
        {
            Console.WriteLine("Creamos el usuario");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Eliminamos el usuario");
        }

        public User Get(int id)
        {
            Console.WriteLine("Obtenemos el usuario");
            return new User();
        }

        public List<User> GetList()
        {
            return new List<User>();
        }

        public void Update(User entity)
        {
            Console.WriteLine("Editamos el usuario");
        }
    }
}
