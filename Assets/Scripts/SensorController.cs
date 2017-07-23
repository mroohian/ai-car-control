using UnityEngine;

public class SensorController : MonoBehaviour {
    private float _value = 0f;
    private Renderer _renderer;
    public GameObject SensorBasePoint;

    public float SensorLength;

    public Material TriggeredMaterial;
    public Material DisableMaterial;

    public float Value { 
        get { 
            return _value;
        } 
    }

	// Use this for initialization
	void Start () {
        _value = 0f;
        _renderer = GetComponent<Renderer>();
        _renderer.enabled = true;
	}
	
    void OnTriggerEnter (Collider other)
    {
        SetValue(other.gameObject);
        _renderer.material = TriggeredMaterial;
    }

    void OnTriggerExit (Collider other)
    {
        _value = 0f;
        _renderer.material = DisableMaterial;
    }

    void OnTriggerStay(Collider other) {
        SetValue(other.gameObject);
        _renderer.material = TriggeredMaterial;
    }

    private void SetValue(GameObject otherObject) {
        var closestPoint = otherObject.GetComponent<Collider>()
            .ClosestPointOnBounds(SensorBasePoint.transform.position);

        var distance = Vector3.Distance(closestPoint, SensorBasePoint.transform.position);        

        var factor = distance / SensorLength;

        _value = 1f - (factor > 0f ? (factor > 1f ? 1f : factor) : 0f);
    }
}
