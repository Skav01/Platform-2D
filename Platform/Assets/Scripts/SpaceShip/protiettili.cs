using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protiettili : MonoBehaviour
{
    private Rigidbody2D rb;
    GameObject proiettile;
    public float speed;
    GameObject enemy;
    public float z;
    public float time;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();

        enemy=GameObject.FindWithTag("enemy");
        //Destroy(gameObject, 3f);
        proiettile = GameObject.FindWithTag("Bullet");
 
    }

    void FixedUpdate()
    {
        //Vector3 pos = transform.position;

        //Vector3 velocity = new Vector3(speed * Time.deltaTime, 0, z);

        //pos += transform.rotation * velocity;
        //transform.position = pos;

        transform.Translate(Vector2.right * speed * Time.deltaTime);


    }

    //void Update()
    //{
    //    // rb.velocity = new Vector2(speed, 0);
    //    Destroy(proiettile, time);
    //}

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("enemy"))
        {
            Object.Destroy(enemy);
            

        }
    }
}

