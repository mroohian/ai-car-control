using AIShared;

namespace AIServer.AI
{
    public static class AiHelper
    {
        public static double[] AiInputToDoubleArray(AI_Input input) => new double[] {
            input.sensor1,
            input.sensor2,
            input.sensor3,
            input.sensor4,
            input.sensor5,
            input.sensor6,
            input.sensor7
        };

        public static AI_Output DoubleArrayToAiOutput(double[] values)
        {
            return new AI_Output {
                Steering = (float)values[0],
                Acceleration = (float)values[1],
                Footbrake = (float)values[2],
                Handbrake = (float)values[3]
            };
        }
    }
}
