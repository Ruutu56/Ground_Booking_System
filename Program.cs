using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
using CRM;
namespace HelloWorld
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello from .Net Framework");
           
            Console.WriteLine("___________________________________________________");

            Person r = new Person();
            r.SetFname("Sanika");
            r.SetLname("Patil");
            r.SetEmail("fjfjhj@gmail.com");
            //r.SetContactno(7587696997);
            Console.WriteLine("Enter contact no.");
            string con = Console.ReadLine();
            r.SetContactno(con);
            Console.WriteLine(r.Display());

            Console.WriteLine("___________________________________________________");
            Person p = new Person("Rutuja", "Patil", "vhgvhvh@gmail.com", "3546576786");
            Console.WriteLine(p.Display());

            Console.WriteLine("___________________________________________________");

            Person q1 = new Person();
            Person q2 = new Person("Kashmira", "Patil", "dsdsdshvh@gmail.com", "3546576786");
            Person q3 = new Person("Kirti", "Mhatre", "gggghvh@gmail.com", "8787776786");
            Console.WriteLine(q1.GetCount()+" objects are created");

            Console.WriteLine("___________________________________________________");

            Account a = new Account(123456, "Shivam Naik", 15000);
            a.Balance = 20000;
            Console.WriteLine(a);
            Console.WriteLine();
            a.Deposite(6000);
            Console.WriteLine(a);
            Console.WriteLine();
            a.Withdraw(3000);
            Console.WriteLine(a);

            Console.WriteLine("___________________________________________________");

            int s1 = 50;
            int s2 = 100;
            Features.Swap(ref s1,ref s2);
            Console.WriteLine("Swapping using ref keyword ===>");
            Console.WriteLine("S1 = "+s1);
            Console.WriteLine("S2 = " + s2);

            int x, y;
            Features.Swap2(out x, out y);
            Console.WriteLine("Swapping using out keyword ===>");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("___________________________________________________");

            Customer c = new Customer("Rutika", 5467576887, "ryryuru@gmail.com");
            c.name = "Saloni";
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
