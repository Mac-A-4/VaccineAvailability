using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    public class VaccineLocation {

        private string vaccineData;
        private string extId;

        public string Name { get; private set; }
        public string Location { get; private set; }
        public Dictionary<string, List<string>> Appointments { get; private set; }

        internal VaccineLocation(SearchRequest.VaccineLocation vaccineLocation) {
            vaccineData = vaccineLocation.vaccineData;
            extId = vaccineLocation.extId;
            Name = vaccineLocation.name;
            Location = vaccineLocation.displayAddress;
            Appointments = new Dictionary<string, List<string>>();
            var availability = new AvailabilityRequest(vaccineData, extId, 1);
            foreach (var date in availability.availability) {
                if (date.available) {
                    Appointments.Add(date.date, new List<string>());
                    var appointments = new AppointmentRequest(vaccineData, extId, date.date);
                    foreach (var time in appointments.slotsWithAvailability) {
                        Appointments[date.date].Add(time.localStartTime);
                    }
                }
            }
        }

        public int GetAppointmentCount() {
            int output = 0;
            foreach (var x in Appointments) {
                output += x.Value.Count;
            }
            return output;
        }

        public override string ToString() {
            return string.Format("{0}: [{1} Days] [{2} Appointments]", Name, Appointments.Count, GetAppointmentCount());
        }

    }

}