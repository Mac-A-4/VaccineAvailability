using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    public static class IndustryName {

        private static readonly List<KeyValuePair<Industry, string>> MAP = new List<KeyValuePair<Industry, string>> {
            new KeyValuePair<Industry, string>(Industry.EducationAndChildcare, "Education and childcare")
        };

        public static string Get(Industry industry) {
            foreach (var x in MAP) {
                if (x.Key == industry) {
                    return x.Value;
                }
            }
            return "";
        }

        public static Industry GetValue(string industry) {
            foreach (var x in MAP) {
                if (x.Value == industry) {
                    return x.Key;
                }
            }
            return Industry.EducationAndChildcare;
        }

    }

}
