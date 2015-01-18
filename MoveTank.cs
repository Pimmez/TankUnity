using UnityEngine;
using System.Collections;

public class MoveTank : MonoBehaviour {
	public float rotationSpeed = 2f;
	public float moveSpeed = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.forward * moveSpeed);

		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.Translate(-Vector3.forward * moveSpeed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate(-Vector3.up * rotationSpeed);
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate(Vector3.up * rotationSpeed);
		}
	}
}
