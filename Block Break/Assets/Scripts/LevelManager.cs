using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

    public List<string> levelNames;

    public void loadScene(string sceneName)
    {
        if (levelNames.Contains(sceneName)) SceneManager.LoadScene(sceneName);
        else Debug.Log("Requested a scene that does not exist or has not been added to the list of Level Names!");
        
    }

    public void quitGame() 
    {
        Application.Quit();
    }
}
