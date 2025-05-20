using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 3f;
    public float leftBoundary = -12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= Vector3.left*speed*Time.deltaTime;

        if(transform.position.x<leftBoundary){
            Destroy(gameObject);
        }
        
    }
}
