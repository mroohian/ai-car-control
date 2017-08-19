using AIShared;

namespace AIServer.AI {
    public class AI_Trainer {
        private AI_EvaluationRequest evaluationRequest;

        public AI_Trainer(AI_EvaluationRequest evaluationRequest) 
        {
            this.evaluationRequest = evaluationRequest;
        }

        internal AI_EvaluationResponse Execute(AI_Logic aiLogic) 
        {                
            // TODO: train and update the model.
            //aiLogic.NeuralNetwork.SetWeights(weights);

            return new AI_EvaluationResponse {
                Success = true
            };
        }
    }
}