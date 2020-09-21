using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject effect;
    
 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            ScoreScript.coinAmount += 1;
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
