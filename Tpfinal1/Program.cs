using final_1._0.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tpfinal1.Clases;

namespace Tpfinal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CreacionDeUsuario
            Usuario usuario = new Usuario();

            usuario.Nombre = "Isaac";
            usuario.Dni = 95773238;
            usuario.Mail = "Isaac.acevedor@gmail.com";
            #endregion
            #region CreacionDeCarrera
            Carrera carrera = new Carrera();
            carrera.Nombre = "Algoridmos";
            carrera.Sigla = "TECAS";
            carrera.Titulo = "Analista en Sistemas";
            carrera.Duracion = 24;
            #endregion
            #region AddUsuarios
            usuario.Add(usuario);
            #endregion
            #region AddCarreras
            carrera.Add(carrera);
            #endregion
            #region ListaUsuarios
            List<Usuario> listaUsuario = usuario.List();
            foreach(Usuario u in listaUsuario) 
            {
                Console.WriteLine("\nNombre del usuario: " + u.Nombre);
                Console.WriteLine("Dni del usuario: " + u.Dni);
                Console.WriteLine("Mail del usuario: " + u.Mail);
            }
            #endregion
            #region ListaCarrera
            List<Carrera> listaCarrera = carrera.List();
            foreach(Carrera c in listaCarrera)
            {
                Console.WriteLine("\nNombre de la carrera: " + c.Nombre);
                Console.WriteLine("Sigla de la carrera: " + c.Sigla);
                Console.WriteLine("Titulo de la carrera: " + c.Titulo);
                Console.WriteLine("Duracion de la carrera: " + c.Duracion + "meses");
            }
            #endregion
        }
    }
}
