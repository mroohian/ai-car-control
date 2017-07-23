using AIShared;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof (CarController))]
public class AICarControl : MonoBehaviour {
    private CarController _carController;

    public SensorController SensorLeft;
    public SensorController SensorFront;
    public SensorController SensorRight;

	// Use this for initialization
	void Start () {
		_carController = GetComponent<CarController>();
	}

    AI_Input GetSensorValues() {
        return new AI_Input {
            sensor1 = SensorLeft.Value,
            sensor2 = SensorFront.Value,
            sensor3 = SensorRight.Value
        };
    }
   
    private void FixedUpdate()
    {
        var sensors = GetSensorValues();

        StartCoroutine(AI_Logic.RunAICoroutine(Time.time, Time.deltaTime, sensors, (output) => { 
            _carController.Move(output.Steering, output.Acceleration, output.Footbrake, output.Handbrake);
        }));
    }
}
