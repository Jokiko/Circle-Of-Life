using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_rotateD : MonoBehaviour
{
    [Range(-180f, 180f)]
    public float rotationSpeed = 90f;

    private float minRotationSpeed = -180f;
    private float maxRotationSpeed = 180f;
    private Vector3 myPosition = new Vector3(3.0f, 2.0f, 3.0f);
    private Vector3 axisVector = new Vector3(0.0f, 1.0f, 0.0f);
    private Vector3 pointVector = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationSpeed = Mathf.Clamp(rotationSpeed, minRotationSpeed, maxRotationSpeed);

        //transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);

       // transform.RotateAround(target.transform.position, new Vector3(0.0f, 0.0f, 0.0f), rotationSpeed * Time.deltaTime);
        transform.RotateAround(pointVector, axisVector, rotationSpeed * Time.deltaTime);

    }
}
