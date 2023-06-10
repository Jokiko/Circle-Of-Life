using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_rotateE : MonoBehaviour
{
    [Range(-180f, 180f)]
    public float rotationSpeed = 90f;

    private float minRotationSpeed = -180f;
    private float maxRotationSpeed = 180f;
    private Vector3 myPosition = new Vector3(3.0f, 2.0f, 3.0f);
    private Vector3 axisVector = new Vector3(0.0f, 1.0f, 0.0f); //movementDirektion
    private Vector3 movementDirection = new Vector3(1.0f, 0.0f, 1.0f);
    private Vector3 pointVector = new Vector3(0.0f, 0.0f, 0.0f);

    private Vector3 previousPosition;
    private Vector3 lastMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        previousPosition = transform.position;
        lastMoveDirection = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        rotationSpeed = Mathf.Clamp(rotationSpeed, minRotationSpeed, maxRotationSpeed);

        transform.RotateAround(pointVector, axisVector, rotationSpeed * Time.deltaTime);
        //transform.RotateAround(myPosition, axisVector, rotationSpeed * Time.deltaTime);
        //transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(lastMoveDirection);


    }

    private void FixedUpdate()
    {
        if (transform.position != previousPosition)
        {
            lastMoveDirection = (transform.position - previousPosition).normalized;
            previousPosition = transform.position;
        }
    }
}
