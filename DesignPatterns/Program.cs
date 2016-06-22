using DesignPatterns.Structural.Proxy.Theory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyClient client = new ProxyClient();
            client.Do();
        }
    }
}
