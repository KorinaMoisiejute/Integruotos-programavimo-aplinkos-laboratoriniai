using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass 
{
  public static List<studentas> studentai = new List<studentas>();
  public static void Main (string[] args) 
  {
  string v;
  string p;
  double e;
  
    Console.WriteLine("Studento vardas:");
    v = Console.ReadLine();
    Console.WriteLine("Studento pavarde:");
    p = Console.ReadLine();
    Console.WriteLine("Studento egzamino rezultatas:");
    e = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Studento namu darbu balai (vesti atskiriant tarpais ir spausti mygtuka Enter:");

string[] arrItems = Console.ReadLine().Split(' ');
List<double> nd = new List<double>(Array.ConvertAll(arrItems, arrTemp =>
Convert.ToDouble(arrTemp)));
    
    studentai.Add(new studentas(v, p, e, nd));
    Console.WriteLine("{0} {1, 10} {2, 10} {3, 2} {4, 12}", "Pavarde", "Vardas", "Galutinis (vid.)","/", "Galutinis (med.)");
    Console.WriteLine("---------------------------------------------------------");
    foreach (var value in studentai)
    {
      Console.WriteLine("{0} {1, 13} {2, 10} {3, 15}", value.p, value.v, value.vidurkis.ToString("#.##"), value.mediana);
    }
    
    
  }
}