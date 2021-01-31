using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        print($"position test {position}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
