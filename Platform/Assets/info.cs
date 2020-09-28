using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class info : MonoBehaviour
{
    public GameObject infoUI;
    public void informazione()
    {
        infoUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
