using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
