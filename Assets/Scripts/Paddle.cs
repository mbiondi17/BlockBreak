using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    
	private Vector3 paddlePosition;

	// Use this for initialization
	void Start () {
	paddlePosition = new Vector3( 0.5f, this.transform.position.y, 0f);        

	}
	
	// Update is called once per frame
	void Update () {
	
	float mousePositionInWorldUnits = (Input.mousePosition.x / Screen.width) * 16;
	paddlePosition.x = Mathf.Clamp(mousePositionInWorldUnits, 0.5f, 15.5f );
	this.transform.position = paddlePosition;

	}
}
