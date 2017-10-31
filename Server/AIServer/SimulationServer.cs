using AIShared;
using AIServer.AI;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace AIServer
{
    public static class SimulationServer
    {
        private static AI_Logic _aiLogic = new AI_Logic();
        

        // Events
        public delegate void InputUpdateDelegate(AI_InputRequest inputRequest);
        public delegate void OutputUpdateDelegate(AI_Output output);
        public static event InputUpdateDelegate InputUpdateEvent;
        public static event OutputUpdateDelegate OutputUpdateEvent;

        public static string HandleRequest(HttpListenerRequest request)
        {
            var path = request.Url.AbsolutePath;

            var json = new StreamReader(request.InputStream).ReadToEnd();

            if (path.Equals("/handleInput/"))
            {
                return HandleInputRequest(json, request);
            }

            if (path.Equals("/sendEvaluation/"))
            {
                return HandleEvaluationRequest(json, request);
            }

            return "{ \"Error\": \"Unsupported endpoint\" }";
        }

        private static string HandleInputRequest(string json, HttpListenerRequest request)
        {
            var inputRequest = JsonConvert.DeserializeObject<AI_InputRequest>(json);

            InputUpdateEvent?.Invoke(inputRequest);

            var evaluationResponse = new AI_InputResponse {
                Output = _aiLogic.RunAI(inputRequest)
            };

            OutputUpdateEvent?.Invoke(evaluationResponse.Output);

            var responseJson = JsonConvert.SerializeObject(evaluationResponse);

            return responseJson;
        }

        public static string HandleEvaluationRequest(string json, HttpListenerRequest request)
        {
            var evaluationRequest = JsonConvert.DeserializeObject<AI_EvaluationRequest>(json);

            var _aiTrainer = new AI_Trainer(evaluationRequest);

            var evaluationResponse = _aiTrainer.Execute(_aiLogic);

            var responseJson = JsonConvert.SerializeObject(evaluationResponse);

            return responseJson;
        }
    }
}
