using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_unterwegs : MonoBehaviour
{
    //the bird won't get closer than this
    private float distanceThreshold = 3f;
    private float speed = 0.5f;

    private bool aufDemWegZuBaum = true;

    public float rotationSpeed = 90f;

    private Vector3 myPosition = new Vector3(3.0f, 2.0f, 3.0f);
    // In die Richtung gehts ab
    private Vector3 axisVector = new Vector3(0.0f, 1.0f, 0.0f);
    

    private Vector3 previousPosition;
    private Vector3 lastMoveDirection;
    

    private GameObject currentTree;
    private Vector3 currentTreePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTree == null){
            currentTree = globelVarManeger.treeQueue.Dequeue();
            currentTreePosition = globelVarManeger.positionsTrees.Dequeue();
            Debug.Log(currentTree);
            Debug.Log("Aktuelle Position: "+currentTreePosition);
            aufDemWegZuBaum = true;
        }
        //Aufgrund von zufaelliger Lebenszeit kann ausgewaehlter Baum trotzdem schon geloescht sein
        if (currentTree != null){
            if(aufDemWegZuBaum){
                // Berechne den Vektor zwischen der aktuellen Position und der Baumposition auf 1m Hoehe
                Vector3 direction = new Vector3(currentTreePosition.x - transform.position.x, -1f, currentTreePosition.z - transform.position.z);
                
                // Check, ob Entfernung zum Baum groesser als Schwelle ist 
                if (direction.magnitude > (distanceThreshold +2))
                {
                    Debug.Log(direction.magnitude);
                    // Berechne die neue Position des Vogels auf dem Weg zum Baum
                    Vector3 newPosition = Vector3.Lerp(transform.position, currentTreePosition - direction.normalized * distanceThreshold, Time.deltaTime * speed);

                    // Setze Position des Vogels auf neue Position
                    transform.position = newPosition;
                    // Damit guckt der vogel in Flugrichtung
                    transform.rotation = Quaternion.LookRotation(lastMoveDirection);
                }
                else{
                    aufDemWegZuBaum = false;
                }
            }
            else{
                //Damit dreht sich der Vogel um den Baum und guckt ihn dabei an
                transform.RotateAround(currentTreePosition, axisVector, rotationSpeed * Time.deltaTime);
            }
        }
        

        
    }

    // Bewegungsvektor berechnen fuer Blickrichtung
    private void FixedUpdate()
    {
        if (transform.position != previousPosition)
        {
            lastMoveDirection = (transform.position - previousPosition).normalized;
            previousPosition = transform.position;
        }
    }
}
