using System.Collections.Generic;

namespace AIShared {
    [System.Serializable]
    public class AI_EvaluationRequest {
        public float SurvivalTime;
        public float TraveledDistance;
        public float FurthestDistance;
        public List<AI_Evaluation> EvaluationResults;
    }
}
