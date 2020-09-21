using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public GameObject head;
    public Rigidbody2D body;

    public float speed;

    

    private bool headIsHere = true;
   
   

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            headIsHere = false;
            movimento();
            Destroy(head);

        }
       
              
    }

    void movimento()
    {
        //body = GetComponent<Rigidbody2D>;
        body.velocity = new Vector2(speed, 0);
    }

}
