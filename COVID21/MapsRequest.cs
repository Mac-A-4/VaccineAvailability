using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace COVID21 {

    internal class MapsRequest {

        private static string KEY = "EXAMPLEKEY";
        private static string URL = "https://maps.googleapis.com/maps/api/geocode/xml?key={1}&components=postal_code:{0}";

        public Location location;

        public MapsRequest(int zip) {
            var url = string.Format(URL, zip, KEY);
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var xdocument = XDocument.Load(response.GetResponseStream());
            var result = xdocument.Element("GeocodeResponse").Element("result");
            var location = result.Element("geometry").Element("location");
            var lat = location.Element("lat");
            var lng = location.Element("lng");
            this.location = new Location();
            this.location.lat = float.Parse((lat.FirstNode as XText).Value);
            this.location.lng = float.Parse((lng.FirstNode as XText).Value);
        }

    }

}
