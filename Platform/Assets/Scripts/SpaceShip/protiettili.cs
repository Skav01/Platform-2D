using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protiettili : MonoBehaviour
{
    public float speed;
    public GameObject enemy;
    public float z;
    void FixedUpdate()
    {
        //Vector3 pos = transform.position;

        //Vector3 velocity = new Vector3(speed * Time.deltaTime, 0, z);

        //pos += transform.rotation * velocity;
        //transform.position = pos;

        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("enemy"))
        {
            Destroy(enemy);
        }
    }
}

