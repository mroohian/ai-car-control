using System;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FollowCar : MonoBehaviour {
    private Transform _carPosition;
    public CarController Car; // the car controller we want to use

    public float Height = 4.0f;
    public float Distance = 10.0f;
    public float Damp = 0.5f;

	// Use this for initialization
	void Awake () {
        _carPosition = Car.GetComponent<Transform>();
	}

	// Use this for initialization
	void Start () {		
	}

    // Update is called once per frame
    void Update() {
         Vector3 currentPos = _carPosition.transform.position;
       
         float currentHeight = this.transform.position.y;
 
         //wantedHeight should be the height of the car's position plus some distance
         float wantedHeight = _carPosition.transform.position.y + Height;
 
         //lerp from currentHeight to wantedHeight
         currentHeight = Mathf.Lerp(currentHeight,wantedHeight, Damp * Time.deltaTime);
       
         //add a distance between the car's position and the camera's desired position, in the x coordinate because
         //of how the x/z axes on the cars are reversed
         Vector3 wantedPos = new Vector3(currentPos.x,currentHeight,currentPos.z - Distance);
               
         //finally, set the camera's position to its desired position
         this.transform.position = wantedPos;
       
         this.transform.LookAt(_carPosition.transform);
    }
}
