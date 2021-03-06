using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID21 {

    public class NotEligibleException : Exception {

        public NotEligibleException() {
            //
        }

        public NotEligibleException(string message) : base(message) {
            //
        }

        public NotEligibleException(string message, Exception inner) : base(message, inner) {
            //
        }

    }

}
