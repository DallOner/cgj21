using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badboy : MonoBehaviour
{
    public bool playerCol = false;
    public float enemySpeed = 0.5f;
    public float enemyDirection = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        /* Debug.Log(col.gameObject.name);
        Debug.Log(col.gameObject.tag); */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
