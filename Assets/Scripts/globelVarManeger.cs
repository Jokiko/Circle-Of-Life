using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globelVarManeger : MonoBehaviour
{

    public static Queue<Vector3> positionsTrees = new Queue<Vector3>();
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (positionsTrees.Count == 0)
            Debug.Log("peek empty  ");
        //else
        //{
          //  Debug.Log("peek  :" + positionsTrees.Peek);
        //}
    }
}
