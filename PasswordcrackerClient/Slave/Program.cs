using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates; 
using System.Threading.Tasks;
using Slave;

namespace Slave
{
    class Program
    {
        static void Main(string[] args)
        {
            Cracking releaseTheCracking = new Cracking();
            releaseTheCracking.RunCracking();
            

            Console.ReadKey(true);


        }


    }
}
