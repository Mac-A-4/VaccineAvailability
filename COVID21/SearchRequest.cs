using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    internal class SearchRequest : MyTurnRequest {

        private int zip;
        private Location location;

        public bool eligible { get; private set; }
        public string vaccineData { get; private set; }
        public VaccineLocation[] locations { get; private set; }

        private class SearchRequestLocationQuery {
            public string[] includePools { get; set; }
        }

        private class SearchRequestForm {
            public Location location { get; set; }
            public string fromDate { get; set; }
            public string vaccineData { get; set; }
            public SearchRequestLocationQuery locationQuery { get; set; }
            public string url { get; set; }
        }

        public class VaccineLocationHours {
            public string[] days { get; set; }
            public string localStart { get; set; }
            public string localEnd { get; set; }
        }

        public class VaccineLocation {
            public string displayAddress { get; set; }
            public float distanceInMeters { get; set; }
            public string extId { get; set; }
            public Location location { get; set; }
            public string name { get; set; }
            public string timezone { get; set; }
            public VaccineLocationHours[] openHours { get; set; }
            public string type { get; set; }
            public string vaccineData { get; set; }
        }

        private class SearchResponse {
            public bool eligible { get; set; }
            public string vaccineData { get; set; }
            public VaccineLocation[] locations { get; set; }
        }

        public SearchRequest(string vaccineData, int zip) {
            this.zip = zip;
            this.location = new MapsRequest(zip).location;
            var request = new SearchRequestForm();
            request.location = this.location;
            request.fromDate = DateTime.Today.ToString("yyyy-MM-dd");
            request.vaccineData = vaccineData;
            request.locationQuery = new SearchRequestLocationQuery();
            request.locationQuery.includePools = new string[] { "default" };
            request.url = "https://myturn.ca.gov/location-select";
            var response = Request<SearchRequestForm, SearchResponse>("https://api.myturn.ca.gov/public/locations/search", request);
            this.eligible = response.eligible;
            this.vaccineData = response.vaccineData;
            this.locations = response.locations;
        }

    }

}
