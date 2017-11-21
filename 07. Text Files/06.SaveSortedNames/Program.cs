using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        using (var writer = new StreamWriter(@"..\..\Names.txt"))
        {
            writer.Write(@"Ivan 
Peter 
Maria 
George");
        }

        List<string> names = new List<string>();
        using (var reader = new StreamReader(@"..\..\Names.txt"))
        {
            string line;
            int i = 0;
            while ((line = reader.ReadLine()) != null)
            {
                names.Add(line);
                i++;
            }
        }

        names.Sort();
        using (var writerSort = new StreamWriter(@"..\..\SortedNames.txt"))
        {
            foreach (var name in names)
            {
                writerSort.WriteLine(name);
            }
        }
    }
}
