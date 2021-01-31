using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCube : MonoBehaviour
{

    public float speed = 100f;
    public Vector3 originalPositon;
    public Quaternion originalRotation;
    // Start is called before the first frame update
    void Start()
    {
         originalPositon = transform.position;
         originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Event e = Event.current;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed;
            transform.Rotate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed;
            transform.Rotate(-0.1f, 0, 0);

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
            transform.Rotate(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
            transform.Rotate(0, 0, 0.1f);
        }


    }

    private void InitialRotation()
    {
        
    }
}
