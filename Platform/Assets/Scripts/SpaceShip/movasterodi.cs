using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movasterodi : MonoBehaviour
{
    public float speed;
    public float z;

    public GameObject effect;

    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(speed * Time.deltaTime, 0, z);

        pos += transform.rotation * velocity;
        transform.position = pos;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Bullet"))
        {
            Debug.Log("colpito");
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }


    }
}
