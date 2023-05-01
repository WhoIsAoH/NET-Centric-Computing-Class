using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //playing with dat file
            FileStream file = new FileStream("myfile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            file.WriteByte((byte)10);
            //Console.WriteLine(file.ReadByte());
            
            file.Close();
            */

            //playing with txt file


            /*read write the texxt file
            StreamWriter sw = new StreamWriter("testing.txt");
            sw.WriteLine("111its me hello \n Testing the\nWriting");
            sw.WriteLine("test gari rako ho la");
           
            sw.WriteLine("its me hello \n Testing the\noverride");
            sw.WriteLine("test gari rako ho la");
            sw.Close();
            //Console.ReadKey();
            //Console.WriteLine();
            //System.IO.File.ReadAllBytes("testing.txt");

            StreamReader sr = new StreamReader("testing.txt");
            String line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sw.Close(); 
            */

            ArrayList names = new ArrayList();
            names.Add("mohit");
            names.Add(true);
            names.Add(98553);
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }


            Hashtable ht = new Hashtable();
            ht.Add("name","nepal chor");
            ht.Add("age", 12);
            ht.Add("isGay",true);

            foreach(var item in ht.Keys)
            {
                Console.WriteLine(item+":" + ht[item]);
            }

            List<string> lst = new List<string>();
            lst.Add("anil");
            lst.Add("silwal");
            lst.Add("aarya");
            foreach (var item in lst)
            {
                Console.WriteLine(item );
            }
            Console.Read();
        }
    }
}
