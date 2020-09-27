using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyShip : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed,jump;

    public GameObject effect;
    public Transform spawnPoint;
    public Transform bonusSpawn;
    public Transform portale;
    
    
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

        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("enemy"))
        {
            Heart.life -= 2;

            if (Heart.life < 0)
            {
                //col.transform.position = spawnPoint.position;

                rb.transform.position = spawnPoint.position;
            }
            // SceneManager.LoadScene("GameOver");
            else if (Heart.life >= 0)
            {
                //col.transform.position = spawnPoint.position;

                rb.transform.position = bonusSpawn.position;
            }


        }

        if (collision.transform.CompareTag("Portale"))
        { 
            rb.transform.position = portale.position;
        }
    }

}
