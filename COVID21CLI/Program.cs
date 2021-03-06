using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COVID21;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace COVID21CLI {
    class Program {

        static void Main(string[] args) {
            var x = new VaccineSearch(18, Industry.EducationAndChildcare, County.Alameda, new int[] { 94555 });
            foreach (var y in x.Locations) {
                Console.WriteLine(y.Name);
                Console.WriteLine(y.Location);
                foreach (var z in y.Appointments) {
                    Console.WriteLine("\t" + z.Key);
                    foreach (var w in z.Value) {
                        Console.WriteLine("\t\t" + w);
                    }
                }
            }
        }

    }
}
