using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string url = Console.ReadLine();
        int startIndex = 0;
        int endIndex;

        endIndex = url.IndexOf(':', startIndex);
        string protocol = url.Substring(startIndex, endIndex - startIndex);

        Console.WriteLine("[protocol] = {0}", protocol);

        startIndex = endIndex + 3;
        endIndex = url.IndexOf('/', startIndex);
        string server = url.Substring(startIndex, endIndex - startIndex);

        Console.WriteLine("[server] = {0}", server);

        startIndex = endIndex;
        string resource = url.Substring(startIndex);

        Console.WriteLine("[resource] = {0}", resource);
    }
}