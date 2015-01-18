using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {

	private Transform[] transforms;
	protected Transform turret;
	protected Vector3 targetPos;

	// Use this for initialization
	protected virtual void Start () {

		bool turretFound = false;

		transforms = gameObject.GetComponentsInChildren<Transform> ();
		foreach(Transform t in transform)
		{
			if(t.gameObject.name == "turret")
			{
				turret = t;
				turretFound = true;
			}
		}

		if (!turretFound) 
		{
			print ("no turret was found in the gameobject");

		}

	}
	
	// Update is called once per frame
	protected virtual void Update() {

		turret.LookAt( targetPos);
	}
}
