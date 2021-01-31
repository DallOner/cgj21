using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    // Start is called before the first frame update
    public bool playerEnter = false;
    public GameObject Enemy;

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log(col.gameObject.name);
        //Debug.Log(col.gameObject.tag);
        if (col.gameObject.name == "Cube"){
            Debug.Log("Marico el que lo lea");
            Instantiate<GameObject>(Enemy);
            Destroy(gameObject);
        }
    }
}
