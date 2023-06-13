using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_unterwegs : MonoBehaviour
{
    public float rotationSpeed = 90f;

    private Vector3 myPosition = new Vector3(3.0f, 2.0f, 3.0f);
    // In die Richtung gehts ab
    private Vector3 axisVector = new Vector3(0.0f, 1.0f, 0.0f);
    // Baum Position
    private Vector3 pointVector = new Vector3(0.0f, 0.0f, 0.0f);


    private Vector3 previousPosition;
    private Vector3 lastMoveDirection;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //Damit dreht sich der Vogel um den Baum und guckt ihn dabei an
        transform.RotateAround(pointVector, axisVector, rotationSpeed * Time.deltaTime);

        // Damit guckt der vogel in Flugrichtung
        //transform.rotation = Quaternion.LookRotation(lastMoveDirection);
    }

    // Bewegungsvektor berechnen für Blickrichtung
    private void FixedUpdate()
    {
        if (transform.position != previousPosition)
        {
            lastMoveDirection = (transform.position - previousPosition).normalized;
            previousPosition = transform.position;
        }
    }
}
