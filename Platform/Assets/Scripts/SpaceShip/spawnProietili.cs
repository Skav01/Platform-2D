using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProietili : MonoBehaviour
{
    
    public GameObject proiettili;
    GameObject enemy;
    public Transform spawnBullet;

    public Transform Distanza;
    public float distance;

    public float spawnRate;
    public float nextSpawn;

    public float time;

    int whatToSpwan;

    void Start()
    {
        
        enemy = GameObject.FindWithTag("enemy");

    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate(quadratorosso, new Vector3(Random.Range(-10,10), Random.Range(-15,15), 0), Quaternion.identity);

        if (Time.time > nextSpawn)
        {
            whatToSpwan = Random.Range(1, 2);

            switch (whatToSpwan)
            {
                case 1:
                    Instantiate(proiettili, new Vector3(spawnBullet.position.x, spawnBullet.position.y, proiettili.transform.position.z), Quaternion.identity);
                     RaycastHit2D groundInfo = Physics2D.Raycast(Distanza.position, Vector2.down, distance);
                            if(groundInfo.collider == false)
                             {
                                 Destroy(proiettili,time);
                             }
                             if (groundInfo.collider == true)
                             {
                                
                             }
        
                    
                    //Instantiate(quadratorosso, transform.position, Quaternion.identity);
                    break;

            }

            nextSpawn = Time.time + spawnRate;
            
        }
    }

}
