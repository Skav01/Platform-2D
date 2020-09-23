using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMuri1 : MonoBehaviour
{
    GameObject Muri1;
    GameObject bottone1;
    // Start is called before the first frame update
    void Start()
    {
        Muri1 = GameObject.FindWithTag("Muri1");
        bottone1 = GameObject.FindWithTag("bottone1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("bottone1"))
        {

            DestroyObject(Muri1);

        }
    }
}
