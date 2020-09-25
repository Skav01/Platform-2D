using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Able : MonoBehaviour
{
    public GameObject ObjectToAble;
    public static bool able = false;
    GameObject bottone;
    // Start is called before the first frame update
    void Start()
    {
        bottone = GameObject.FindWithTag("bottone");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("bottone"))
            ObjectToAble.SetActive(true);
    }
}
