using final_1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_1._0.Clases
{
    class Usuario : IABMC<Usuario>, IUsuario
    {
        static List<Usuario> Usuarios = new List<Usuario>();
        private static int LasId = 1;
        #region IID
        public int ID { get; set ; }
        #endregion
        #region IABMC
        public void Add(Usuario usuario)
        {
            //Comprobar si existe un usuario con el mismo Dni. Si existe el dni o el mail, no permita agregar el usuario
            if (DniExist(usuario.Dni))
            {
                throw new Exception("Existe otro usuario con el mismo Dni");
            }
            //comprobar si existe un usuario con el mismo Mail. Si existe el dni o el mail, no permita agregar el usuario
            if (MailExists(usuario.Mail))
            {
                throw new Exception("Existe otro usuario con el mismo Mail");
            }
            usuario.ID = LasId;
            LasId++;
            Usuarios.Add(usuario);
        }
        public void Modify(Usuario usuario)
        {
            //buscar con el metodo Find la ID del usuario y asignarlo al objeto "u"
            Usuario u = Find(usuario);
            //de no encontrar al usuario, mostrar un mensaje donde no se encuentra al usuario buscado
            if(u == null)
            {
                throw new Exception("No existe el usuario que desea modificar.");
            }
            //Modificar el nombre del usuario
            u.Nombre= usuario.Nombre;
        }
        public void Erase(Usuario usuario)
        {
            //Acceder y recorrer la lista
            foreach(Usuario u in Usuarios)
            //comprobar si existe un usuario con 
            {
                if(u.Dni == usuario.Dni) 
                {
                    //Verificar si en la lista existe un usuario con el mismo dni y de encontrarlo, eliminar al usuario buscado
                    Usuarios.Remove(usuario);
                    return;
                }
            }
            //En caso de no encontrarlo, mostrar una exepcion
            throw new Exception("No se pudo borrar el Usuario con el dni:" + usuario.Dni);
        }
        public Usuario Find(Usuario usuario)
        {
            //Acceder y recorrer la lista 
            foreach(Usuario u in Usuarios) 
            {
                //Verificar si en la lista existe un usuario con el mismo ID y de encontrarlo retornar al usuario buscado
                if(u.ID == usuario.ID)
                {  
                    return u; 
                }
            }
            //En caso de no encontrarlo, mostrar una exepcion
            throw new Exception("No se encontro el Usuario con la ID:"+ usuario.ID);
        }
        #endregion
        #region IUsuario
        public string Nombre { get ; set ; }
        public int Dni { get; set ; }
        public string Mail { get ; set ; }

        public bool DniExist(int dni)
        {
            //Acceder y recorrer la lista de Usuarios
            foreach (Usuario usuario in Usuarios)
            //Acceder a la lista para comprobar si existe el dni
            //verificar si coincide con algun dni existente de un usuario, retornar con un tru. De lo contrario retornar un false
            {
                if (usuario.Dni == dni) return true;
            }
            return false;
            

            
        }
        public bool MailExists(string mail)
        {
            //Acceder y recorrer la lista de Usuarios
            foreach (Usuario usuario in Usuarios)
            //Acceder a la lista para comprobar si existe el mail
            //verificar si coincide con algun mail existente de un usuario, retornar con un tru. De lo contrario retornar un false
            {
                if (usuario.Mail == mail) return true;
            }
            return false;
        }
        public Usuario FindbyDni(int dni)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Dni == dni)
                {
                    return u;
                }
            }
            throw new Exception("No se encuentra el Dni que busca.");
        }
        
        public Usuario FindbyMail(string mail)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.Mail == mail)
                {
                    return u;
                }
            }
            throw new Exception("No se encuentra el Mail que busca.");
        }
        public List<Usuario> List()
        {
            return Usuarios;
        }
        #endregion
    }
}
