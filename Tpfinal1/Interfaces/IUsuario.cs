using System;
using final_1._0.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_1._0.Interfaces
{
    internal interface IUsuario
    {
        string Nombre { get; set; }
        int Dni { get; set; }
        string Mail { get; set; }
        bool DniExist(int dni);
        bool MailExists(string mail);
        Usuario FindbyMail(string mail);
        Usuario FindbyDni(int dni);

        List<Usuario> List();
    }
}
