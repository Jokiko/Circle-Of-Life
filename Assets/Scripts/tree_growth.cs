using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_growth : MonoBehaviour
{
    private float growthRate = 0.05f;
    private float minSize = 0.1f;
    private float maxSize = 1.5f; 

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.one * minSize;
    }

    private void Update()
    {
        // Scale object
        transform.localScale += Vector3.one * growthRate * Time.deltaTime;

    
        if (transform.localScale.y >= maxSize)
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
