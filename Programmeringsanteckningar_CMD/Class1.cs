using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringsanteckningar_CMD
{
    class fivePartPrint
    {
        public void main()
        {
            for (int i = 0; i <= 105; i += 5)
            {
                if (i == 0) Console.Write(i);
                else if ((i % 50) == 0) Console.Write("X");
                else Console.Write(i);

                if (i < 105) Console.Write(", ");
            }

            Console.ReadKey();
        }
    }
}
