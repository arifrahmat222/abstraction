using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abstraction.Interface;
using Abstraction.abstractclass;


namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Abstraksi dengan Abstract Class. ");
            Console.WriteLine();
            alatmusik AlatMusik;

            AlatMusik = new petik();
            AlatMusik.jenisAlatMusik();

            AlatMusik = new gesek();
            AlatMusik.jenisAlatMusik();

            AlatMusik = new tiup();
            AlatMusik.jenisAlatMusik();

            Console.WriteLine();
            Console.WriteLine("Abstraksi dengan Interface. ");
            Console.WriteLine();
            Ibahanbakar bbm;

            bbm = new minyak();
            bbm.bbm();

            bbm = new nonminyak();
            bbm.bbm();

            Console.ReadKey();
        }
    }
}
