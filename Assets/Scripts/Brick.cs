using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public static int breakableCount = 0;

	[SerializeField]private Sprite[] hitSprites;
	private bool isBreakable;
	private LevelManager levelManager;
	private int hits = 0;

	// Use this for initialization
	void Start () {
		if(levelManager == null) {
			levelManager = FindObjectOfType<LevelManager>();
		}
		isBreakable = this.tag == "Breakable";
		if(isBreakable) {
			breakableCount++;
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
		if(isBreakable) {
			HandleHits();
		}
	}

	void HandleHits() {
		hits++;
		int maxHits = hitSprites.Length + 1;

		if(hits >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed();
			GameObject.Destroy(this.gameObject);
			
		}
		else {
			int spriteIndex = hits - 1;
			if(hitSprites[spriteIndex])	this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}
