using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidi : MonoBehaviour
{
    public GameObject meteoriti;

    public float spawnRate;
    public float nextSpawn;

    public float x1;
    public float x2;
    public float y1;
    public float y2;
    public float z;
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
                    Instantiate(meteoriti, new Vector3(Random.Range(x1, x2), Random.Range(y1, y2), z), Quaternion.identity);

                    //Instantiate(quadratorosso, transform.position, Quaternion.identity);
                    break;

            }

            nextSpawn = Time.time + spawnRate;

        }
    }
}
