using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.abstractclass
{
    public class petik : alatmusik
    {
        public override void jenisAlatMusik()
        {
            Console.WriteLine("ALAT MUSIK YANG DIPETIK ADALAH GITAR, UKULELE, HARPA");
        }
    }
}
