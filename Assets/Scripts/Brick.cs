using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	[SerializeField] private int life;
	private LevelManager levelManager;
	private int hits;

	// Use this for initialization
	void Start () {
		if(life == 0) life = 1;
		hits = 0;
		if(levelManager == null) {
			levelManager = FindObjectOfType<LevelManager>();
		}
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
		if(hits >= life) {
			Brick[] bricks = GameObject.FindObjectsOfType<Brick>();
			if(bricks.Length == 1) {
				levelManager.loadNextLevel();
			}
			GameObject.Destroy(this.gameObject);
		}
	}
}
