using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibary;

namespace 命令行_hello_world_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double a = match.Add(11, 22);
            Console.WriteLine(a);
            double b = match.Div(11, 0);
            Console.WriteLine(b);
            double c = match.Mul(900,520);
            Console.WriteLine(c);
            Form cccc = new Form();
            cccc.Text = "命令行窗口";
            cccc.Width = 900;
            cccc.Height = 900;
            cccc.ShowDialog();
        
        }
    }
}
