using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSFA_WinForms
{
    public class FiltroDeBuscaBD
    {
        public bool FiltrarPorPeriodo { get; set; }
        public string DataInicial { get; set; }
        public string DataFinal { get; set; }

        public bool FiltrarPorUsuario { get; set; }
        public string NomeUsuario { get; set; }
    }
}
