using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_rotateA : MonoBehaviour
{

    private float rotationSpeed = 90f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate tree around y-axis by 90 degree per second
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
