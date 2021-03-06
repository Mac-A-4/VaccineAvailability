using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    internal class AvailabilityRequest : MyTurnRequest {

        public VaccineAvailability[] availability { get; private set; }

        private static string GetURL(string extId) {
            return string.Format("https://api.myturn.ca.gov/public/locations/{0}/availability", extId);
        }

        private class AvailabilityRequestForm {
            public string startDate { get; set; }
            public string endDate { get; set; }
            public string vaccineData { get; set; }
            public int doseNumber { get; set; }
            public string url { get; set; }
        }

        public class VaccineAvailability {
            public string date { get; set; }
            public bool available { get; set; }
            public string vaccineData { get; set; }
        }

        private class AvailabilityResponse {
            public string vaccineData { get; set; }
            public string locationExtId { get; set; }
            public VaccineAvailability[] availability { get; set; }
        }

        public AvailabilityRequest(string vaccineData, string extId, int dose) {
            var request = new AvailabilityRequestForm();
            request.startDate = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
            request.endDate = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");
            request.vaccineData = vaccineData;
            request.doseNumber = dose;
            request.url = "https://myturn.ca.gov/appointment-select";
            var response = Request<AvailabilityRequestForm, AvailabilityResponse>(GetURL(extId), request);
            availability = response.availability;
        }

    }

}
