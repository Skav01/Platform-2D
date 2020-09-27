using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProietili : MonoBehaviour
{
    public GameObject proiettili;
    public Transform spawnBullet;

    public float spawnRate;
    public float nextSpawn;

  

    int whatToSpwan;

    void Start()
    {

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
                    //Instantiate(proiettili, new Vector3(spawnBullet.position.x,spawnBullet.position.y,proiettili.transform.position.z), Quaternion.identity);
                    Instantiate(proiettili);
                    //Instantiate(quadratorosso, transform.position, Quaternion.identity);
                    break;

            }

            nextSpawn = Time.time + spawnRate;

        }
    }

}
