using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLEvel : MonoBehaviour
{
    //public int nextSceneLoad;
    public string levelName;
    void Start()
    {
        //nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void nextLevel()
    {

        SceneManager.LoadScene(levelName);
        Time.timeScale = 1f;

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(nextSceneLoad);

        //if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
        //{
        //    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
        //}


    }
}
