using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    public static class CountyName {

        private static readonly List<KeyValuePair<County, string>> MAP = new List<KeyValuePair<County, string>> {
            new KeyValuePair<County, string>(County.Alameda, "Alameda")
        };

        public static string Get(County county) {
            foreach (var x in MAP) {
                if (x.Key == county) {
                    return x.Value;
                }
            }
            return "";
        }

        public static County GetValue(string county) {
            foreach (var x in MAP) {
                if (x.Value == county) {
                    return x.Key;
                }
            }
            return County.Alameda;
        }

    }

}
