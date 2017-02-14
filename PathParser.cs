using UnityEngine;
using System.Collections;

public class PathParser : MonoBehaviour {

	public virtual RecursivePath GetRecursivePath(NodeGoal nodeGoal) {

		return new RecursivePath();

	}

	public virtual KinodynamicSteering GetOutput(RecursivePath path, NodeGoal nodeGoal){
		return new  RecursiveSteering();

	}


}
