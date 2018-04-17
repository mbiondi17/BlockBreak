using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	[SerializeField]private Paddle paddle;
	private bool gameStarted = false;

	private Vector3 distanceToPaddle;

	// Use this for initialization
	void Start () {
		distanceToPaddle = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameStarted){
			this.transform.position = paddle.transform.position + distanceToPaddle;
			if(Input.GetMouseButtonDown(0)) {
			gameStarted = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
		}
		}

		
	}
}
