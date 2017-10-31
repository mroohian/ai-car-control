using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour {
    private float _collisionTime;
    private AICarControl _aiCarControl;
    private CarController _carController;
    private CarOdometer _odometer;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        AI_Logic.Start();
    }

	// Use this for initialization
	void Start () {
		_aiCarControl = GetComponent<AICarControl>();
        _carController = GetComponent<CarController>();
        _odometer = GetComponent<CarOdometer>();
    }
	
    void OnCollisionEnter (Collision other)
    {
        if (_aiCarControl == null || _carController == null)
        {
            return;
        }

        // Break and disable AI control
        _aiCarControl.enabled = false;
        _carController.Move(0, 0, 0, 0);
        if (_odometer != null) {
            _odometer.Reset();
        }

        // Analyze the results
        StartCoroutine(AI_Logic.RunEvaluationCoroutine(() => {
            SceneManager.LoadScene(0);    

            // Enable AI control
            _aiCarControl.enabled = true;            
        }));                  
    }
}
