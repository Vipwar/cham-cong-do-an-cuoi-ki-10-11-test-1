using _4_ChamCong_DeTaiCuoiKi.form;
using _4_ChamCong_DeTaiCuoiKiSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_ChamCong_DeTaiCuoiKi
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
