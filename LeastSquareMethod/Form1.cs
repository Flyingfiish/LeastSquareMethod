using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace LeastSquareMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawGraph();
        }

        private double a;
        private double b;

        private double Func(double x)
        {
            return a * x + b;
        }

        private void DrawGraph()
        {
            GraphPane pane = zedGraphControl1.GraphPane;

            pane.Title.Text = "Метод наименьших квадратов";

            pane.CurveList.Clear();

            PointPairList list = new PointPairList();
            PointPairList list2 = new PointPairList();



            var myX = new double[] { -2, -1, 1, 2, 3 };
            var myY = new double[] { 5, -2, 4, 7, 10 };
            LSM LsmSolver = new LSM(myX, myY);

            var results = LsmSolver.GetParameters();

            a = results.Item1;
            b = results.Item2;

            label2.Text = a.ToString();
            label4.Text = b.ToString();

            double xmin = myX[0] - 1;
            double xmax = myX[myX.Length -1 ] + 1;

            for (double x = xmin; x <= xmax; x += 0.001)
            {
                list.Add(x, Func(x));
            }

            for (var i = 0; i < myX.Length; i++)
            {
                list2.Add(myX[i], myY[i]);
            }

            pane.AddCurve("Результат", list, Color.Blue, SymbolType.None);

            LineItem myCurve = pane.AddCurve("Данные", list2, Color.Red, SymbolType.Diamond);

            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 7;

            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();
        }
    }
}
