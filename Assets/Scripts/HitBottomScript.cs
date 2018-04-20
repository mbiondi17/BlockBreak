using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBottomScript : MonoBehaviour {

    private LevelManager lm;

	// Use this for initialization
	void Start () {
		if(lm == null) {
			lm = GameObject.FindObjectOfType<LevelManager>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider) {
        lm.LoadScene("Lose");
    }
}
