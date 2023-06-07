using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateC : MonoBehaviour
{
    private GameObject oak_Tree;
    private GameObject sparrow;

    [Range(-180f, 180f)]
    public float rotationSpeed = 90f;

    private float minRotationSpeed = -180f;
    private float maxRotationSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        oak_Tree = GameObject.Find("Oak_Tree");
        sparrow = GameObject.Find("Sparrow");
    }

    // Update is called once per frame
    void Update()
    {
        // Limit roatation speed between min and max value 
        rotationSpeed = Mathf.Clamp(rotationSpeed, minRotationSpeed, maxRotationSpeed);
        // Rotate tree around y-axis by 90 degree per second
        sparrow.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        oak_Tree.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
