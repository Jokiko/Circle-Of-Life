using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    private int cameraMode = 0; //0 = standard, 1 = 1st person, 2 = 3rd person, 3 = bird's eye view

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private float birdsEyeHeight = 40f;

    // Start is called before the first frame update
    void Start()
    {
        //Saving original camera position to reset it in cameraMode 0 
        originalPosition = transform.position;
        originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cameraMode = (cameraMode + 1) % 4; 
        }

        switch(cameraMode){
            case 0:
                transform.position = originalPosition;
                transform.rotation = originalRotation;
                break;
            case 1: 
                break;
            case 2:
                break;
            case 3:
                Vector3 cameraPosition = transform.position;
                cameraPosition.y = birdsEyeHeight;
                transform.position = cameraPosition;

                // turn camera to the floor
                transform.rotation = Quaternion.Euler(90f, 0f, 0f); 
                break;           
        }
    }
}
