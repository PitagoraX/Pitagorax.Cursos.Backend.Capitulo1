
//Este es nuestro espacio de nombres
using System.Collections.Generic;

namespace Pitagorax.Cursos.Backend.Intro
{
    //Esto es una interfaz
    public interface IUser
    {
        //Esto es una propiedad
        public int Id { get; set; }

        //Esto es una propiedad
        public string Name { get; set; }

        //Esto es una propiedad
        public string Surname { get; set; }

        //Esto es una propiedad
        //El rol importante es ADM
        public List<string> Roles { get; set; }

        //Esto es un método/función
        bool IsAdmin();

    }
}
