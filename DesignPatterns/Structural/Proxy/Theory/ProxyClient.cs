using System;

namespace DesignPatterns.Structural.Proxy.Theory
{
    public class ProxyClient
    {
        public void Do()
        {
            Console.WriteLine("Proxy Pattern\n");

            ISubject subject = new Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            subject = new ProtectionProxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine((subject as ProtectionProxy).Authenticate("secret"));
            Console.WriteLine((subject as ProtectionProxy).Authenticate("abracadabra"));
            Console.WriteLine(subject.Request());
        }
    }
}
