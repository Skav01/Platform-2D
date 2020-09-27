using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyShip : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed,jump;
    public GameObject bullet;
    public Transform spawnposition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.velocity = Vector2.up * jump;

        //Instantiate(bullet,transform.position,transform.rotation);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("enemy"))
        {

            Destroy(gameObject);

        }
    }

}
