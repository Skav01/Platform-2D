using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyYellow : MonoBehaviour
{
    public GameObject enemy;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="Body")
        {
            // Debug.Log("COLPITO");
            Destroy(enemy);

        }


    }
}
