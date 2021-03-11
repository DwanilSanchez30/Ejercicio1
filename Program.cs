using System;

namespace TareaMétodos
{
    class Program
    {
        private string Nombre;
        private int Monto;

        public Program(string Cliente)
        {
            Nombre = Cliente;
            Monto = 0;
        }

        public void Depositar(int D)
        {
            Monto = Monto + D;
        }

        public void Retirar(int D)
        {
            Monto = Monto - D;
        }

        public int RMonto()
        {
            return Monto;
        }

        public void Mostrar()
        {
            Console.WriteLine(Nombre+" Usted tiene la cantidad de "+Monto+" Pesos");
        }
    }

    class SucursalBanco
    {
        private Program Cliente1, Cliente2, Cliente3;
        public SucursalBanco()
        {
            Cliente1=new Program("Dwanil R. Sánchez");
            Cliente2=new Program("Miguel Fernandez");
            Cliente3=new Program("Danilo Medina");
        }

        public void Cajero()
        {
            Cliente1.Depositar(5000);
            Cliente2.Depositar(8000);
            Cliente3.Depositar(30000);
            Cliente1.Retirar(500);
            Cliente2.Retirar(6000);
            Cliente3.Retirar(10000);
        }
        public void TotalDepósitos()
        {
            int Cant =  Cliente1.RMonto () +
                        Cliente2.RMonto () +
                        Cliente3.RMonto ();
            Cliente1.Mostrar();
            Console.WriteLine();
            Cliente2.Mostrar();
            Console.WriteLine();
            Cliente3.Mostrar();
            Console.WriteLine();
            Console.WriteLine ("El banco cuenta con una cantidad de: " + Cant);
        }

        static void Main(string[] args)
        {
            SucursalBanco Banco = new SucursalBanco();
            Banco.Cajero();
            Console.WriteLine();
            Banco.TotalDepósitos();
            Console.WriteLine("Presione una tecla");
            Console.ReadLine();
        }
    }
}