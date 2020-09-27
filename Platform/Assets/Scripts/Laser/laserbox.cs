using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserbox : MonoBehaviour
{
    public GameObject laser;
    public GameObject effect;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log("colpito");
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(laser);

        }


    }
}
