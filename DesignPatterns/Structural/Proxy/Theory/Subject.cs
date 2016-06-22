using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.Theory
{
    internal class Subject
    {
        public string Request()
        {
            return "Subject Request " + "Choose left door\n";
        }
    }
}
