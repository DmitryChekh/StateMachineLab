using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineLab {
    public class StateMachine {

        public StateMachine() {
        }
        public Dictionary<string, StateAndOut> StateAndOuts { get;set; }
        public string FirstState { get; set; }

    }

    public class StateAndOut {
        public string State { get; set; }
        public string Out { get; set; }
    }
}
