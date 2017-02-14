using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Perc : MonoBehaviour {

	/*

	We cast a ray in front of the agent; when the ray collides with a wall, 
the target object is placed in a new position 
taking into consideration its distance from the wall 
and the safety distance declared and delegating the steering calculations to the 
Seek behavior; this creates the 
illusion of the agent avoiding the wall.

*/

	public bool acyclicWeight = false;
	public bool acyclicPriority = false;
	public float priorityThreshold = 0.2f;
	public bool acyclicPipeline = false;
	
	//Kinodynamic params
	public float maxSpeed;
	public float maxAccel;
	public float maxRotation; 
	public float rotation;
	public Vector3 velocitu;
	protected RecursiveSteering recursiveSteering;

	void Start()

	{

	//Default to default values.
	velocity = Vector3.zero;
	recursiveSteering = new RecursiveSteering();

	

	}

	public void SetSteering(RecursiveSteering steering) {
		this.steering = steering;

	}	

	//The update function deals with the avatar kinematics or movement in 3D space.

	public virtual void Update(){
	
		Vector3 displacement = velocity * Time.deltaTime;
		orientation += rotation * Time.deltaTime;
	//We need to limit the orientation values
	//to be between 0 to 360 degrees.

	if(orientation < 0.0f) 
		orientation += 360.0f;
	else if(orientation > 360.0f)
	orientation -= 360.0f;

	transform.Translate(displacement, Space.World);
	transform.rotation = new Quaternion();
	transform.Rotate(Vector3.up, orientation);

	}
	
	/*Finally, we implement the LateUpdate function, which takes care of updating the
 steering for the next frame according to the current frame's calculations:*/

	public virtual void LateUpdate(){

	velocity += recursiveSteering.linear * Time.deltaTime;
	rotation += recursiveSteering.angular * Time.deltaTime;

	if(velocity.magnitude > maxSpeed){

		velocity.Normalize();
		velocity = velocity * maxSpeed;
	}

	if(recursiveSteering.angular == 0.0f) {
		rotation = 0.0f;

	}

	if(recursiveSteering.linear.sqrMagntitude == 0.0f) {

		velocity = Vector3.zero;
	}

	recursiveSteering = new RecursiveSteering();
   }

}
