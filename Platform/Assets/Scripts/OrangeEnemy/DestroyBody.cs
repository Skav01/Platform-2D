using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBody : MonoBehaviour
{
    public GameObject body;
    public float time;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            
            Destroy(body,time);

        }


    }
}
