using UnityEngine;
using System.Collections;

public class PercBehaviour : MonoBehaviour {

	public GameObject target;
	protected Perc perc;

	public virtual void Awake(){

	perc = gameObject.GetComponent<Perc>();
	

}

public virtual void Update(){

	perc.SetSteering(GetSteering());
}
	
public virtual Steering GetSteering(){

	return new Steering();

}






}
