using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseUI;
    public void stop()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
