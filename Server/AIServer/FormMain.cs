using AIShared;
using System;
using System.Windows.Forms;

namespace AIServer
{
    public partial class FormMain : Form {        
        private WebServer _ws;

        public FormMain() {
            InitializeComponent();
            SimulationServer.InputUpdateEvent += this.FormMain_InputUpdateEvent;
            SimulationServer.OutputUpdateEvent += this.FormMain_OutputUpdateEvent;
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            buttonStop_Click(sender, e);

            SimulationServer.ResetLogic();

            _ws = new WebServer(SimulationServer.HandleRequest, "http://localhost:8888/handleInput/", "http://localhost:8888/sendEvaluation/");

            _ws.Run();

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            if (_ws != null) {
                _ws.Stop();

                _ws = null;
            }

            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void FormMain_InputUpdateEvent(AI_InputRequest inputRequest)
        {
            this.InvokeIfRequired(() => {
                textBoxSensor1.Text = inputRequest.Input.sensor1.ToString();
                textBoxSensor2.Text = inputRequest.Input.sensor2.ToString();
                textBoxSensor3.Text = inputRequest.Input.sensor3.ToString();
                textBoxSensor4.Text = inputRequest.Input.sensor4.ToString();
                textBoxSensor5.Text = inputRequest.Input.sensor5.ToString();
                textBoxSensor6.Text = inputRequest.Input.sensor6.ToString();
                textBoxSensor7.Text = inputRequest.Input.sensor7.ToString();
            });
        }


        private void FormMain_OutputUpdateEvent(AI_Output output) {
            this.InvokeIfRequired(() => {
                textBoxAcceleration.Text = output.Acceleration.ToString();
                textBoxSteering.Text = output.Steering.ToString();
                textBoxFootbrake.Text = output.Footbrake.ToString();
                textBoxHandbrake.Text = output.Handbrake.ToString();
            });
        }
    }
}
