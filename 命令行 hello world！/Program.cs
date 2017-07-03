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
        { xiao add = new xiao();
            int a = add.fum(6, 7);
            Console.WriteLine(a);
            int b = add.Sum1To(100);
            Console.WriteLine(b);
            int s = add.fum(100, 200);
            Console.WriteLine(s);
            Form f = new Form();
            f.WindowState = FormWindowState.Normal;
            //f.ShowDialog();
            int[] array = new int[100];
            array[0] = 13;
            sbyte sb;
            Console.WriteLine(sizeof(byte));
            int sss = 100;
            int ss = -100;
            string str = Convert.ToString(sss, 2);
            string str2 = Convert.ToString(ss, 2);
            Console.WriteLine(str);
            Console.WriteLine(str2);



            


            
            


        }
    }
    class xiao
    {
        public int fum(int x,int b)
        {
            return x + b;
        }

        //public int Sum1To(int x)
        //{
        //    int a = 0;
        //    for (int i = 0; i <= x; i++)
        //    {
        //        a += i;
        //    }
        //    return a;
        //}
        public int Sum1To(int x)
        {
            if (x==1)
            {
                return 1;
            }
            else
            {
                return x + Sum1To(x - 1);      
            }
            
        }

    }
    class Stod
    {
        public static int Amount;
        public int Age;
        public string Name;
        public double Add(double a,double b )
        {
            return a + b;
        }

    }
}
