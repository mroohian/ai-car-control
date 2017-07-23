using UnityEngine.UI;
using UnityEngine;

public class InfoPanelUpdator : MonoBehaviour {
    private float _startTime;
    public AICarControl Car;
    public Text TimeText;
    public Text Sensors1Text;
    public Text Sensors2Text;
    public Text Sensors3Text;

	// Use this for initialization
	void Start () {
        _startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		TimeText.text = string.Format("Time: {0:F1}s", Time.time - _startTime);
        Sensors1Text.text = string.Format("Sensor1: {0:F2}", Car.SensorLeft.Value);
        Sensors2Text.text = string.Format("Sensor2: {0:F2}", Car.SensorFront.Value);
        Sensors3Text.text = string.Format("Sensor3: {0:F2}", Car.SensorRight.Value);
	}
}
