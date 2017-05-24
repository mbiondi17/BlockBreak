using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    
    private Vector3 paddlePosition;

	// Use this for initialization
	void Start () {
        Vector3 paddlePosition = new Vector3(this.transform.position.x, this.transform.position.y, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
        paddlePosition.x = (Input.mousePosition.x / Screen.width) * 16;

        this.transform.position = paddlePosition;

	}
}
