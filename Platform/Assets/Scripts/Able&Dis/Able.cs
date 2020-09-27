using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Able : MonoBehaviour
{
    public GameObject ObjectToAble;
    GameObject bottone;
    // Start is called before the first frame update
    void Start()
    {
        bottone = GameObject.FindWithTag("bottone");
        ObjectToAble = GameObject.FindWithTag("Able");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Renderer rend = ObjectToAble.GetComponent<Renderer>();
        if (rend.enabled == false)
            if (col.transform.CompareTag("bottone"))
                //Debug.Log("Colpito");
                rend.enabled = true;
    }
}
