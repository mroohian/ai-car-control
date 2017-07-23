using System.Collections.Generic;

namespace AIShared {
    [System.Serializable]
    public class AI_EvaluationRequest {
        public float SurvivalTime;
        public AI_Model CurrentModel;
        public List<AI_Evaluation> EvaluationResults;
    }
}
