using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ConsoleApplication2;

namespace Aerial_Imaging_UAV_Simulator
{
    static class Program
    {
    //FlightGearData data = new FlightGearData();
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
       
    }


    }
}
