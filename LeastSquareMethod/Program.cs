using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSquareMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //var x = new double[] { 0, 1, 2, 4 };
            //var y = new double[] { 0.2, 0.9, 2.1, 3.7 };
            //var myX = new double[] { -2, -1, 1, 2, 3 };
            //var myY = new double[] { 5, -2, 4, 7, 10 };
            //LSM LsmSolver = new LSM(x, y);
                
            //var results = LsmSolver.GetParameters();
            //Console.WriteLine("a = " + results.Item1 + " b = " + results.Item2);
        }
    }
}
