using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {
    private float _collisionTime;
    private AICarControl _aiCarControl;
    private CarController _carController;
    private CarOdometer _odometer;
    private bool _crashed;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        AI_Logic.Restart();
    }

	// Use this for initialization
	void Start () {
		_aiCarControl = GetComponent<AICarControl>();
        _carController = GetComponent<CarController>();
        _odometer = GetComponent<CarOdometer>();
        _crashed = false;
    }
	
    void OnCollisionEnter (Collision other)
    {
        if (_crashed || _aiCarControl == null || _carController == null)
        {
            return;
        }

        // Break and disable AI control
        _crashed = true;
        _aiCarControl.enabled = false;
        _carController.Move(0, 0, 0, 0);
        var survivalTime = _odometer.SurvivalTime;
        var traveledDistance = _odometer.Distance;
        var furthestDistance = _odometer.FarthestDistance;

        // Analyze the results
        StartCoroutine(AI_Logic.RunEvaluationCoroutine(survivalTime, traveledDistance, furthestDistance, () => {
            SceneManager.LoadScene(0);

            // Reset odometer
            if (_odometer != null) {
                _odometer.Reset();
            }

            // Enable AI control
            _aiCarControl.enabled = true;
            _crashed = false;
        }));                  
    }
}
