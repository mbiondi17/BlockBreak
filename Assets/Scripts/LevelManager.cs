using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    public List<string> levelNames;
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

    public void loadScene(string sceneName)
    {
        if (levelNames.Contains(sceneName)) {
            currentLevel = sceneName;
            SceneManager.LoadScene(sceneName);
        }
        else Debug.Log("Requested a scene that does not exist or has not been added to the list of Level Names!");
        
    }

    public void quitGame() 
    {
        Application.Quit();
    }
}
