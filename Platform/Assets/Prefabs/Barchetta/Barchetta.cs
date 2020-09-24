using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barchetta : MonoBehaviour
{
    public Transform rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            movimento();

        }
    }
    void movimento()
    {
        //body = GetComponent<Rigidbody2D>;
        transform.Translate(Vector2.right * speed * Time.deltaTime);





    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
