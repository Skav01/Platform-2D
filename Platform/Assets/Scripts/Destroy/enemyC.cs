using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyC : MonoBehaviour
{
   GameObject enemyCatenozzo;
    GameObject bottone;
    // Start is called before the first frame update
    void Start()
    {
        enemyCatenozzo = GameObject.FindWithTag("enemyC");
        bottone = GameObject.FindWithTag("bottone");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("bottone"))
        {

            Object.Destroy(enemyCatenozzo);

        }
    }    
}
