using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public float bulletSpeed = 0.5f;
    public float depth = -78f;
    public float timeToDetroySelf = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(2.9f, 11.2f, depth);
        DestroyObjectDelayed();
    }

    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(this.gameObject, timeToDetroySelf);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - bulletSpeed, transform.position.y, depth);
    }
}
