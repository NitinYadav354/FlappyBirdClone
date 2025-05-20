using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    public float speed = 2f;
    public float leftBoundary = -22f;
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
