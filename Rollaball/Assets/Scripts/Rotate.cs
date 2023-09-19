using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotationSpeed;
    public bool isX;
    public bool isY;

    // Update is called once per frame
    void Update()
    {  
        if (isX)
        {
            transform.Rotate(new Vector3(rotationSpeed, 0, 0) * Time.deltaTime);
        }
        if (isY)
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
        }
    }
}
