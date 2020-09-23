using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDeath : MonoBehaviour
{
    public GameObject effect;
    public GameObject enemy;
    // public int fallcube;

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            // col.transform.position = spawnPoint.position;
            
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(enemy);

            //ScoreScript.scoreValue = fallcube -1;

        }
    }
}
