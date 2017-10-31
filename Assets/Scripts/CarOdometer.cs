using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOdometer : MonoBehaviour {
    private Vector3 _startPosition;
    private Vector3 _lastPosition;

    public GameObject Car;

    public float Distance = 0.0f;

    public float FarthestDistance = 0.0f;

    // Use this for initialization
    void Start () {
        _startPosition = _lastPosition = Car.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        var newPosition = Car.transform.position;

        // distnace traveled
        var dist = PointsDistance(_lastPosition, newPosition);

        Distance += dist;

        // Farthest distance
        dist = PointsDistance(_startPosition, newPosition);

        if (dist > FarthestDistance) {
            FarthestDistance = dist;
        }

        // Update last position
        _lastPosition = newPosition;
    }

    private float PointsDistance(Vector3 point1, Vector3 point2) {
        var dx = point2.x - point1.x;
        var dz = point2.z - point1.z;

        return Mathf.Sqrt(dx * dx + dz * dz);
    }

    public void Reset() {
        Distance = 0;
        FarthestDistance = 0;
    }
}
