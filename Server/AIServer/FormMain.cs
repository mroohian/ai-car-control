using AIShared;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AIServer {
    public partial class FormMain : Form {
        private WebServer _ws;

        public FormMain() {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            buttonStop_Click(sender, e);

             _ws = new WebServer(HandleRequest, "http://localhost:8888/handleInput/", "http://localhost:8888/sendEvaluation/");

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
 
        public static string HandleRequest(HttpListenerRequest request) {
            var path = request.Url.AbsolutePath;

            var json = new StreamReader(request.InputStream).ReadToEnd();

            if (path.Equals("/handleInput/")) {
                return HandleInputRequest(json, request);
            }

            if (path.Equals("/sendEvaluation/")) {
                return HandleEvaluationRequest(json, request);
            }

            return "{ \"Error\": \"Unsupported endpoint\" }";
        }

        private static string HandleInputRequest(string json, HttpListenerRequest request) {
            var inputRequest = JsonConvert.DeserializeObject<AI_InputRequest>(json);
            
            var evaluationResponse = new AI_InputResponse {
                Output = new AI_Output {
                    Steering = 0,
                    Acceleration = 0.3f,
                    Footbrake = 0,
                    Handbrake = 0
                }
            };

            var responseJson = JsonConvert.SerializeObject(evaluationResponse);

            return responseJson;   
        }

        public static string HandleEvaluationRequest(string json, HttpListenerRequest request)
        {
            var evaluationRequest = JsonConvert.DeserializeObject<AI_EvaluationRequest>(json);

            var model = evaluationRequest.CurrentModel;

            var evaluationResponse = new AI_EvaluationResponse {
                Model = model
            };

            var responseJson = JsonConvert.SerializeObject(evaluationResponse);

            return responseJson;    
        }
    }
}
