using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public float jumpforce;
    public int extraJumps;
    public int extraJumpsValue;
    
    public Transform spawnPoint;

    public GameObject effect;

    public GameObject gameOverUI;

    public AudioSource coin;
    

    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb=GetComponent<Rigidbody2D>();
        coin = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }

    void Update()
    {
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        //if(Input.touchCount>0 && extraJumps >0) // touchscreen
        {
            rb.velocity = Vector2.up * jumpforce;
            extraJumps--;

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true)
        /*else if (Input.touchCount>0 && extraJumps == 0 && isGrounded == true) */ // touchscreen
        {
            rb.velocity = Vector2.up * jumpforce;
            // ScoreScript.scoreValue += 1;
        }
        
        
    }





    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.transform.CompareTag("KillZone") || col.transform.CompareTag("enemy"))
        {
            //Instantiate(effect, transform.position, Quaternion.identity);
            //Destroy(gameObject);

            

            //col.transform.position = spawnPoint.position;

            rb.transform.position = spawnPoint.position;

            // SceneManager.LoadScene("GameOver");

            //ScoreScript.scoreValue=0;
        }
        if (col.transform.CompareTag("Coin"))
        {
            coin.Play();
        }
    }

}
