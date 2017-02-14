using UnityEngine;
using System.Collections;

public class FastPursue : RecursiveSeek {

	public float maxPrediction;
	private GameObject targetAux;
	private Perc targetPercival;


}

public  override void Awake(){

	base.Awake();
	targetPercival = target.GetComnponent<Percival>();
	targetAux = target;
	target = new GameObject();

}
