using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    internal class AppointmentRequest : MyTurnRequest {

        public VaccineAppointment[] slotsWithAvailability { get; private set; }

        private static string GetURL(string extId, string date) {
            return string.Format("https://api.myturn.ca.gov/public/locations/{0}/date/{1}/slots", extId, date);
        }

        private class AppointmentRequestForm {
            public string vaccineData { get; set; }
            public string url { get; set; }
        }

        public class VaccineAppointment {
            public string localStartTime { get; set; }
            public int durationSeconds { get; set; }
        }

        private class AppointmentResponse {
            public string vaccineData { get; set; }
            public string locationExtId { get; set; }
            public string date { get; set; }
            public VaccineAppointment[] slotsWithAvailability { get; set; }
        }

        public AppointmentRequest(string vaccineData, string extId, string date) {
            var request = new AppointmentRequestForm();
            request.vaccineData = vaccineData;
            request.url = "https://myturn.ca.gov/appointment-select";
            var response = Request<AppointmentRequestForm, AppointmentResponse>(GetURL(extId, date), request);
            this.slotsWithAvailability = response.slotsWithAvailability;
        }

    }

}
