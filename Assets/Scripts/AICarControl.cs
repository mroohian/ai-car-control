using AIShared;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof (CarController))]
public class AICarControl : MonoBehaviour {
    private CarController _carController;

    public SensorController SensorLeft;
    public SensorController SensorFront;
    public SensorController SensorRight;
    public float SteeringSensor;
    public float SpeedSensor;
    public float AccelSensor;
    public float BrakeSensor;

    // Use this for initialization
    void Start () {
		_carController = GetComponent<CarController>();
	}

    AI_Input GetSensorValues() {
        SteeringSensor = (_carController.CurrentSteerAngle + 1f) / 2f;
        SpeedSensor = _carController.CurrentSpeed / _carController.MaxSpeed;
        AccelSensor = _carController.AccelInput;
        BrakeSensor = _carController.BrakeInput;

        return new AI_Input {
            sensor1 = SensorLeft.Value,
            sensor2 = SensorFront.Value,
            sensor3 = SensorRight.Value,
            sensor4 = SteeringSensor,
            sensor5 = SpeedSensor,
            sensor6 = AccelSensor,
            sensor7 = BrakeSensor
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
