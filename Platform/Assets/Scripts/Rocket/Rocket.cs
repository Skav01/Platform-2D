using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float speed;
    public GameObject effect;
    // Start is called before the first frame update
    void FixedUpdate()
    {

        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground"||col.gameObject.tag=="enemy")
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }


    }
}
