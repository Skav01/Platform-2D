using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMuri2 : MonoBehaviour
{
    GameObject Muri2;
    GameObject bottone2;
    // Start is called before the first frame update
    void Start()
    {
        Muri2 = GameObject.FindWithTag("Muri2");
        bottone2 = GameObject.FindWithTag("bottone2");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("bottone2"))
        {

            Object.Destroy(Muri2);

        }
    }
}
