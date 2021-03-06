using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    public class VaccineSearch {

        public List<VaccineLocation> Locations { get; private set; }

        public int GetAppointmentCount() {
            int output = 0;
            foreach (var x in Locations) {
                output += x.GetAppointmentCount();
            }
            return output;
        }

        public VaccineSearch(int Age, Industry Industry, County County, int[] Zips) {
            Locations = new List<VaccineLocation>();
            var eligibility = new EligibilityRequest(Age, Industry, County);
            if (!eligibility.eligible) {
                throw new NotEligibleException("Not Eligible.");
            }
            foreach (var zip in Zips) {
                var search = new SearchRequest(eligibility.vaccineData, zip);
                foreach (var location in search.locations) {
                    Locations.Add(new VaccineLocation(location));
                }
            }
        }

    }

}
