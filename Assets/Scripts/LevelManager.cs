using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

public class LevelManager : MonoBehaviour {

    private string currentLevel = "Start";
    private static LevelManager instance;


    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
        if(instance) GameObject.Destroy(this);
        else instance = this;
    
    }

    public void LoadScene(string sceneName)
    {
        try{
            currentLevel = sceneName;
            SceneManager.LoadScene(sceneName);
        }
        catch(Exception ex) {
             Debug.Log(ex.InnerException);
             Debug.Log("You probably tried to load some level that doesn't exist!");
        }
        
    }

    public void BrickDestroyed() {
        if(Brick.breakableCount <= 0) {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
