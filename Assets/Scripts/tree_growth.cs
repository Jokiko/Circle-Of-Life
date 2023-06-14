using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_growth : MonoBehaviour
{
    private float growthRate = 0.05f;
    private float minSize = 0.1f;
    private float maxSize = 1.5f; 
    private int lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.one * minSize;
        //Random number dictating how long the tree will live after reaching full growth
        lifeTime = Random.Range(0, 601);
        //Debug.Log("Dieser Baum wird "+lifeTime+ " Frames leben.");
    }

    private void Update()
    {
        if (transform.localScale.y >= maxSize)
        {
            lifeTime = lifeTime -1;
            if(lifeTime == 0){
                //gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
        else{
            // Scale tree
            transform.localScale += Vector3.one * growthRate * Time.deltaTime;
        }
    }
}
