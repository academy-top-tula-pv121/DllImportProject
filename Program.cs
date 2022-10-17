using System.Runtime.InteropServices;

namespace DllImportProject
{
    internal class Program
    {
        [DllImport("CppDll.dll", EntryPoint = "PrintHello")]
        public static extern void MyPrintHello();

        [DllImport("CppDll.dll", EntryPoint = "GaussSum")]
        public static extern int MyGaussSum(int number);
        static void Main(string[] args)
        {
            //MyPrintHello();
            Console.WriteLine(MyGaussSum(1000));
        }
    }
}