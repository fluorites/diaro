﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//  Создание пространства имен Онуфрия Токарева.
namespace Onuphrius {
    // Создание пространства имен дневника.
    namespace Diaro {
        static class CProgram {
            /// <summary>
            /// Главная точка входа для приложения.
            /// </summary>
            [STAThread]
            static void Main() {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Diaro.CConverterForm());
            }
        }
    }
}