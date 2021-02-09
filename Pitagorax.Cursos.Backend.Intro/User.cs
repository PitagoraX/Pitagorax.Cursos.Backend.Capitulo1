
//Este es nuestro espacio de nombres
using System.Collections.Generic;

namespace Pitagorax.Cursos.Backend.Intro
{
    //Esto es una clase que implementa la interfaz IUser
    public class User: IUser
    {
        public int Id { get; set; }

        //Esto es una propiedad
        public string Name { get; set; }

        //Esto es una propiedad
        public string Surname { get; set; }

        //Esto es una propiedad
        public List<string> Roles { get; set; }

        //Esto es un método/función
        public bool IsAdmin()
        {
            //Esto es un bucle
            //role es una variable
            foreach(var role in Roles)
            {
                //Esto es un IF
                if (role == "ADM")
                    return true;
            }

            return false;
        }
    }
}
