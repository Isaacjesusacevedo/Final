using final_1._0.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tpfinal1.Clases;

namespace Tpfinal1.Interfaces
{
    internal interface ICarrera
    {
        string Nombre { get; set; }
        string Sigla { get; set; }
        string Titulo { get; set; }
        int Duracion { get; set; }

        bool NombreExists(string nombre);
        bool SiglaExists(string sigla);
        Carrera FindBySigla(string sigla);
        List<Carrera> List();
    }
}
