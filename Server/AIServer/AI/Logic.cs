using System;
using AIShared;

namespace AIServer.AI {
    public class AI_Logic {
        internal AI_Output RunAI(AI_InputRequest inputRequest) {
            return new AI_Output {
                Steering = 0,
                Acceleration = 0.3f,
                Footbrake = 0,
                Handbrake = 0
            };
        }
    }
}
