using UnityEngine.UI;
using UnityEngine;

public class InfoPanelUpdator : MonoBehaviour {
    private CarOdometer _odometer;
    private float _startTime;
    public AICarControl Car;
    public Text TimeText;
    public Text DistanceText;
    public Text Sensors1Text;
    public Text Sensors2Text;
    public Text Sensors3Text;
    public Text Sensors4Text;
    public Text Sensors5Text;
    public Text Sensors6Text;
    public Text Sensors7Text;
    public Text Sensors8Text;

    // Use this for initialization
    void Start () {
        _startTime = Time.time;

        _odometer = Car.GetComponent<CarOdometer>();
    }
	
	// Update is called once per frame
	void Update () {
		TimeText.text = string.Format("Time: {0:F1}s", Time.time - _startTime);
        DistanceText.text = string.Format("Distance: {0:F1}m", _odometer.Distance);

        Sensors1Text.text = string.Format("S1 (L): {0:F2}", Car.SensorLeft.Value);
        Sensors2Text.text = string.Format("S2 (F): {0:F2}", Car.SensorFront.Value);
        Sensors3Text.text = string.Format("S3 (R): {0:F2}", Car.SensorRight.Value);
        Sensors4Text.text = string.Format("S4 (STE): {0:F2}", Car.SteeringSensor);
        Sensors5Text.text = string.Format("S5 (SPE): {0:F2}", Car.SpeedSensor);
        Sensors6Text.text = string.Format("S6 (ACC): {0:F2}", Car.AccelSensor);
        Sensors7Text.text = string.Format("S7 (BRK): {0:F2}", Car.BrakeSensor);
        Sensors8Text.text = "";
    }
}
