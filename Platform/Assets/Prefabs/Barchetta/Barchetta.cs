using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barchetta : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            rb.velocity = Vector2.up * speed * Time.deltaTime;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {

            Update();

        }
    }

}
