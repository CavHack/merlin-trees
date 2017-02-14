using UnityEngine;
using System.Collections;

public class RecursiveSeeking : PercBehaviour {

	public override RecursiveSteering GetRecursiveSteering(){
		
		RecursiveSteering recursiveSteering = new RecursiveSteering();
		recursiveSteering.linear = target.transform.position - transform.position;

		recursiveSteering.linear.Normalize();
		recursiveSteering.linear = recursiveSteering.linear * perc.maxAccel;
		
		return RecursiveSteering;		

	}


}
