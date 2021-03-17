using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateMachineLab {
    public partial class Form1 : Form {
        List<StateMachine> stateMachines;

        public Form1() {
            InitializeComponent();
            stateMachines = new List<StateMachine>();
            stateMachines.Add(new StateMachine {
                FirstState = "b1",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut {State = "b2", Out = "" },
                    ["z2"] = new StateAndOut { State = "b1", Out = "w1"},
                    ["z3"] = new StateAndOut { State = "b1", Out = "w3"},
                    ["z4"] = new StateAndOut { State = "b7", Out = ""},
                }
            });
            stateMachines.Add(new StateMachine {
                FirstState = "b2",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut { State = "b2", Out = "w1" },
                    ["z2"] = new StateAndOut { State = "b3", Out = ""},
                    ["z3"] = new StateAndOut { State = "b2", Out = "w4"},
                    ["z4"] = new StateAndOut { State = "b2", Out = ""},
                }
            });
            stateMachines.Add(new StateMachine {
                FirstState = "b3",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut { State = "b2", Out = "" },
                    ["z2"] = new StateAndOut { State = "b3", Out = "w2"},
                    ["z3"] = new StateAndOut { State = "b3", Out = "w2"},
                    ["z4"] = new StateAndOut { State = "b4", Out = "w2"},
                }
            });
            stateMachines.Add(new StateMachine {
                FirstState = "b4",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut { State = "b4", Out = "w2" },
                    ["z2"] = new StateAndOut { State = "b7", Out = ""},
                    ["z3"] = new StateAndOut { State = "b3", Out = ""},
                    ["z4"] = new StateAndOut { State = "", Out = ""},
                }
            });
            stateMachines.Add(new StateMachine {
                FirstState = "b5",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut { State = "b7", Out = "" },
                    ["z2"] = new StateAndOut { State = "b2", Out = ""},
                    ["z3"] = new StateAndOut { State = "b5", Out = "w3"},
                    ["z4"] = new StateAndOut { State = "", Out = ""},
                }
            });
            stateMachines.Add(new StateMachine {
                FirstState = "b6",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut { State = "b6", Out = "w3" },
                    ["z2"] = new StateAndOut { State = "", Out = ""},
                    ["z3"] = new StateAndOut { State = "b1", Out = ""},
                    ["z4"] = new StateAndOut { State = "b6", Out = "w2"},
                }
            });
            stateMachines.Add(new StateMachine {
                FirstState = "b7",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut { State = "b6", Out = "" },
                    ["z2"] = new StateAndOut { State = "b7", Out = "w3"},
                    ["z3"] = new StateAndOut { State = "b1", Out = ""},
                    ["z4"] = new StateAndOut { State = "b7", Out = "w1"},
                }
            });
            stateMachines.Add(new StateMachine {
                FirstState = "b8",
                StateAndOuts = new Dictionary<string, StateAndOut> {
                    ["z1"] = new StateAndOut { State = "b1", Out = "" },
                    ["z2"] = new StateAndOut { State = "b3", Out = ""},
                    ["z3"] = new StateAndOut { State = "b4", Out = ""},
                    ["z4"] = new StateAndOut { State = "b5", Out = ""},
                }
            });
            textBox1.Text = "b1";
        }

        private void button1_Click(object sender, EventArgs e) {
            var test = stateMachines.FirstOrDefault(t => t.FirstState == textBox1.Text);
            textBox1.Text = test.StateAndOuts["z1"].State;
            textBox2.Text = test.StateAndOuts["z1"].Out;
        }

        private void button2_Click(object sender, EventArgs e) {
            var test = stateMachines.FirstOrDefault(t => t.FirstState == textBox1.Text);
            textBox1.Text = test.StateAndOuts["z2"].State;
            textBox2.Text = test.StateAndOuts["z2"].Out;
        }

        private void button3_Click(object sender, EventArgs e) {
            var test = stateMachines.FirstOrDefault(t => t.FirstState == textBox1.Text);
            textBox1.Text = test.StateAndOuts["z3"].State;
            textBox2.Text = test.StateAndOuts["z3"].Out;
        }

        private void button4_Click(object sender, EventArgs e) {
            var test = stateMachines.FirstOrDefault(t => t.FirstState == textBox1.Text);
            textBox1.Text = test.StateAndOuts["z4"].State;
            textBox2.Text = test.StateAndOuts["z4"].Out;
        }
    }
}







