using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public int headCount = 0;
    // public GameObject effect;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            headCount += 1;
            // Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
