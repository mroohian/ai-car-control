using AIShared;

namespace AIServer.AI {
    public class AI_Trainer {
        private AI_EvaluationRequest evaluationRequest;

        public AI_Trainer(AI_EvaluationRequest evaluationRequest) {
            this.evaluationRequest = evaluationRequest;
        }

        internal object Execute() {
            return new AI_EvaluationResponse {
                Model = evaluationRequest.CurrentModel
            };
        }
    }
}