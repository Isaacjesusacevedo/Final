using final_1._0.Clases;
using final_1._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tpfinal1.Interfaces;

namespace Tpfinal1.Clases
{
    class Carrera : IABMC<Carrera>, ICarrera

    {
        static List<Carrera> Carreras = new List<Carrera>();
        private static int LasId = 1;
        #region IID
        public int ID { get; set; }
        #endregion
        #region ICarrera
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }

        public Carrera FindBySigla(string sigla)
        {
            foreach (Carrera c in Carreras)
            {
                if (c.Sigla == sigla)
                {
                    return c;
                }
            }

            throw new Exception("No se encuentra la sigla que busca");
        }

        public bool NombreExists(string nombre)
        {
            foreach(Carrera c in Carreras) 
            {
                if(c.Nombre.Equals(nombre))
                {
                    return true;
                }
            }
            return false;
        }

        public bool SiglaExists(string sigla)
        {
            foreach (Carrera c in Carreras)
            {
                if (c.Sigla.Equals(sigla))
                {
                    return true;
                }
            }
            return false;
        }
        public List<Carrera> List()
        {
            return Carreras;
        }
        #endregion
        #region IABMC
        public void Add(Carrera carrera)
        {
            //Comprobar si existe una Carrera con las mismas siglas. Si existe que no permita agregar carrera
            if (SiglaExists(carrera.Sigla))
            {
                throw new Exception("Existe otro usuario con el mismo Dni");
            }
            //Comprobar si existe una Carrera con el mismo nombre. Si existe que no permita agregar carrera
            if (NombreExists(carrera.Nombre))
            {
                throw new Exception("Existe otro usuario con el mismo Mail");
            }
            carrera.ID = LasId;
            LasId++;
            Carreras.Add(carrera);
        }

        public void Erase(Carrera carrera)
        {
            foreach (Carrera c in Carreras)
            {
                if(c.Sigla== carrera.Sigla)
                {
                    Carreras.Remove(c);
                    return;
                }
            }
        }

        public Carrera Find(Carrera carrera)
        {
            //Acceder y recorrer la lista 
            foreach (Carrera c in Carreras)
            {
                //Verificar si en la lista existe una carrera con el mismo ID y de encontrarlo retornar la carrera buscad
                if (c.ID == carrera.ID)
                {
                    return c;
                }
            }
            //En caso de no encontrarlo, mostrar una exepcion
            throw new Exception("No se encontro la Carrera con la ID:" + carrera.ID);
        }

        public void Modify(Carrera carrera)
        {
            //buscar con el metodo Find la carrera y asignarlo al objeto "c"
            Carrera c = Find(carrera);
            //de no encontrar la carrera, mostrar un mensaje donde no se encuentra la carrera
            if (c == null)
            {
                throw new Exception("No existe el usuario que desea modificar.");
            }
            //Modificar el nombre de la carrera
            c.Nombre = carrera.Nombre;
        }
        #endregion
    }
}
