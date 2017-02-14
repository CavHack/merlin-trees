using UnityEngine;
using System.Collections;

public class RecursiveFlee: PercBehaviour {

	public override RecursiveSteering GetRecursiveSteering(){
		
		RecursiveSteering recursiveSteering = new RecursiveSteering();
		recursiveSteering.linear = transform.position - target.transform.position;
		recursiveSteering.linear.Normalize();
		recursiveSteering.linear = recursiveSteering.linear * perc.maxAccel;
		
		return recursiveSteering;

	}


}
