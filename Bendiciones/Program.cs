﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bendiciones
{
    static class Program
    {
        public static Service.ServicioClient dbController = new Service.ServicioClient();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmPrincipal("usuario"));
            //Application.Run(new frmPrincipalSec("usuario"));
            //Application.Run(new FormLogin());

        }

    }
}
