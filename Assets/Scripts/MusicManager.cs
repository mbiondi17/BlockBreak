using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    private static MusicManager instance;

	void Awake () {
        // set up singleton instance and ensure duplicates are removed.
        GameObject.DontDestroyOnLoad(gameObject);
        if (instance) GameObject.Destroy(this.gameObject);
        else instance = this;
	}
	
	void Update () {
	
	}
}
