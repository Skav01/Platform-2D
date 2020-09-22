using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMuri : MonoBehaviour
{
    GameObject Muri;
    GameObject bottone;
    // Start is called before the first frame update
    void Start()
    {
        Muri = GameObject.FindWithTag("Muri");
        bottone = GameObject.FindWithTag("bottone");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("bottone"))
        {

            DestroyObject(Muri);

        }
    }
}
