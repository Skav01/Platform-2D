using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject PauseUI;
    public void resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
