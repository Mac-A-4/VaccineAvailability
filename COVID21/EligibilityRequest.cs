using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    internal class EligibilityRequest : MyTurnRequest {

        private string age;
        private string industry;
        private string county;

        private static string GetAgeRangeName(int age) {
            if (age <= 15) {
                return "Under 16";
            }
            else if (age <= 49) {
                return "16 - 49";
            }
            else if (age <= 64) {
                return "50 - 64";
            }
            else if (age <= 74) {
                return "65 - 74";
            }
            else {
                return "75 and older";
            }
        }

        private class EligibilityRequestQuestion {
            public string id { get; set; }
            public object value { get; set; }
            public string type { get; set; }
        }

        private class EligibilityRequestForm {
            public EligibilityRequestQuestion[] eligibilityQuestionResponse { get; set; }
            public string url { get; set; }
        }

        public bool eligible { get; private set; }
        public string vaccineData { get; private set; }

        private class ElibibilityResponse {
            public bool eligible { get; set; }
            public string vaccineData { get; set; }
        }

        public EligibilityRequest(int age, Industry industry, County county) {
            this.age = GetAgeRangeName(age);
            this.industry = IndustryName.Get(industry);
            this.county = CountyName.Get(county);
            var request = new EligibilityRequestForm();
            request.url = "https://myturn.ca.gov/screening";
            request.eligibilityQuestionResponse = new EligibilityRequestQuestion[7];
            request.eligibilityQuestionResponse[0] = new EligibilityRequestQuestion();
            request.eligibilityQuestionResponse[0].id = "q.screening.18.yr.of.age";
            request.eligibilityQuestionResponse[0].type = "multi-select";
            request.eligibilityQuestionResponse[0].value = new string[] { "q.screening.18.yr.of.age" };
            request.eligibilityQuestionResponse[1] = new EligibilityRequestQuestion();
            request.eligibilityQuestionResponse[1].id = "q.screening.health.data";
            request.eligibilityQuestionResponse[1].type = "multi-select";
            request.eligibilityQuestionResponse[1].value = new string[] { "q.screening.health.data" };
            request.eligibilityQuestionResponse[2] = new EligibilityRequestQuestion();
            request.eligibilityQuestionResponse[2].id = "q.screening.privacy.statement";
            request.eligibilityQuestionResponse[2].type = "multi-select";
            request.eligibilityQuestionResponse[2].value = new string[] { "q.screening.privacy.statement" };
            request.eligibilityQuestionResponse[3] = new EligibilityRequestQuestion();
            request.eligibilityQuestionResponse[3].id = "q.screening.eligibility.age.range";
            request.eligibilityQuestionResponse[3].type = "single-select";
            request.eligibilityQuestionResponse[3].value = this.age;
            request.eligibilityQuestionResponse[4] = new EligibilityRequestQuestion();
            request.eligibilityQuestionResponse[4].id = "q.screening.eligibility.industry";
            request.eligibilityQuestionResponse[4].type = "single-select";
            request.eligibilityQuestionResponse[4].value = this.industry;
            request.eligibilityQuestionResponse[5] = new EligibilityRequestQuestion();
            request.eligibilityQuestionResponse[5].id = "q.screening.eligibility.county";
            request.eligibilityQuestionResponse[5].type = "single-select";
            request.eligibilityQuestionResponse[5].value = this.county;
            request.eligibilityQuestionResponse[6] = new EligibilityRequestQuestion();
            request.eligibilityQuestionResponse[6].id = "q.screening.accessibility.code";
            request.eligibilityQuestionResponse[6].type = "text";
            request.eligibilityQuestionResponse[6].value = "";
            var response = Request<EligibilityRequestForm, ElibibilityResponse>("https://api.myturn.ca.gov/public/eligibility", request);
            this.eligible = response.eligible;
            this.vaccineData = response.vaccineData;
        }

    }

}
