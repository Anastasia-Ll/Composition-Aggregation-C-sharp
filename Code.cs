using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public class Professor
    {
        public string Name;
        public Professor(string Name)
        {
            this.Name = Name;
        }
    }
    public class Department{
        public string name;
        public List<Professor> members;
        public Department(string name, List<Professor> members)
        {
            this.name = name;
            this.members = members;
        }
    }
    public class University{
        public List<Department> faculity = new List<Department>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            University univer = new University();

            Professor prof1 = new Professor("Videnin");
            Professor prof2 = new Professor("Korneeva");
            Professor prof3 = new Professor("Zakarluka");
            univer.faculity.Add(new Department("ISIT", new List<Professor>() { prof1, prof2, prof3 }));

            Professor prof01 = new Professor("Serduk");
            Professor prof02 = new Professor("Milkovich");
            Professor prof03 = new Professor("Aganina");
            univer.faculity.Add(new Department("ICMMS", new List<Professor>() { prof01, prof02, prof03 }));
    
            univer = null;
            Console.WriteLine("Professors of ISIT:" + "\n" + prof1.Name + "\n" + prof2.Name + "\n" + prof3.Name);
            Console.WriteLine("\nProfessors of ICMMS:" + "\n" + prof01.Name + "\n" + prof02.Name + "\n" + prof03.Name);
            Console.ReadKey();
        }
    }
}