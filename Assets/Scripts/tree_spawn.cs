using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_spawn : MonoBehaviour
{
    private GameObject oak_tree; 
    
    private float delayBetweenSpawns = 5.0f; 
    private float minSpawnRadius = 15.0f; 
    private float maxSpawnRadius = 30.0f; 

    private void Start()
    {
        oak_tree = GameObject.Find("Oak_Tree");
        InvokeRepeating("SpawnObject", 0.0f, delayBetweenSpawns);
    }

    private void SpawnObject()
    {
            if (oak_tree != null){
                //calculate random position of new tree
                Vector2 randomPosition = Random.insideUnitCircle.normalized * Random.Range(minSpawnRadius, maxSpawnRadius);
                Vector3 spawnPosition = new Vector3(randomPosition.x, 0.0f, randomPosition.y);
                globelVarManeger.positionsTrees.Enqueue(spawnPosition);
                //Debug.Log("vektor3  :" + spawnPosition);

                //create tree, scale it for visibility and add tree_growth script to it
                GameObject new_tree = Instantiate(oak_tree, spawnPosition, Quaternion.identity);
                new_tree.transform.localScale = new Vector3(1f,1f,1f);
                new_tree.AddComponent<tree_growth>();
                globelVarManeger.treeQueue.Enqueue(new_tree);
            }
    }
}
