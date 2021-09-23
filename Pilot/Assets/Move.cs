using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{  
    public float speed = 2.0f;
    public float jump = 10.0f;
   
    // Start is called before the first frame update 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            transform.Translate(1, 0, 0);
        } else
        {
            return;
        }
        
    } 


}
