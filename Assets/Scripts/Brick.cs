using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	[SerializeField] private int life;
	private int hits;

	// Use this for initialization
	void Start () {
		if(life == 0) life = 1;
		hits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnCollisionEnter2D(Collision2D other)
	{
		hits++;
		Debug.Log(hits + " hits out of " + life);
		if(hits >= life) {
			GameObject.Destroy(this.gameObject);
		}
	}
}
