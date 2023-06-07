using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_rotateC : MonoBehaviour
{
    public GameObject oak_Tree;
    private Rigidbody Oak_TreeRigidbody;

    private tree_rotateC trc;

    // Start is called before the first frame update
    void Start()
    {
        //find tree rotate script
       trc = FindObjectOfType<tree_rotateC>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // get rotation speed based on tree's rotation speed
        float rotationSpeed = trc.rotationSpeed;

        // rotating sparrow around y-axis
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
