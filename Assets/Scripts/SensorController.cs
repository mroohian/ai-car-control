using UnityEngine;

public class SensorController : MonoBehaviour {
    const int hittableLayerMask = 1 << 10;

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
        if (_renderer == null)
        {
            return;
        }

        SetValue(other.gameObject);
        _renderer.material = TriggeredMaterial;
    }

    void OnTriggerExit (Collider other)
    {
        if (_renderer == null)
        {
            return;
        }

        _value = 0f;
        _renderer.material = DisableMaterial;
    }

    void OnTriggerStay(Collider other) 
    {
        if (_renderer == null)
        {
            return;
        }

        SetValue(other.gameObject);
        _renderer.material = TriggeredMaterial;
    }

    private void SetValue(GameObject otherObject) {
        //Debug.DrawRay(SensorBasePoint.transform.position, SensorBasePoint.transform.forward * 10, Color.red, 2, true);

        RaycastHit hit = default(RaycastHit);
        if (!Physics.Raycast(SensorBasePoint.transform.position, SensorBasePoint.transform.forward, out hit, 1000f, hittableLayerMask))
        {
            return;
        }

        //var hitRay = hit.point - SensorBasePoint.transform.position;
        //Debug.DrawRay(SensorBasePoint.transform.position, hitRay, Color.blue, 5, true);
        //Debug.DrawRay(hit.point, Vector3.up * 5, Color.green, 2, true);
       
        var distance = Vector3.Distance(hit.point, SensorBasePoint.transform.position);

        //Debug.Log("D: " + distance);

        var factor = distance / SensorLength;

        _value = 1f - (factor > 0f ? (factor > 1f ? 1f : factor) : 0f);
    }
}
