using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMuri3 : MonoBehaviour
{
    GameObject Muri3;
    GameObject bottone3;
    // Start is called before the first frame update
    void Start()
    {
        Muri3 = GameObject.FindWithTag("Muri3");
        bottone3 = GameObject.FindWithTag("bottone3");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("bottone3"))
        {

            Object.Destroy(Muri3);

        }
    }
}
