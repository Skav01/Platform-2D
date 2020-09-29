using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlScript : MonoBehaviour
{
    //public Button l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16,
    //              l17, l18, l19, l20, l21, l22, l23, l24, l25, l26, l27, l28, l29, l30, l31,
    //              l32, l33, l34, l35, l36, l37, l38, l39, l40, l41;

    public Button[] LevelButt;
    public string levelname;
    // int lvps;   //level Passed

    
    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i=0; i<LevelButt.Length; i++)
        {
            if(i+2>levelAt)
            {
                LevelButt[i].interactable = false;
            }
        }
        
    }

    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

  
}
