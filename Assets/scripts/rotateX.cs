using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateX : MonoBehaviour
{
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = 0.03f;
        transform.Rotate(new Vector3(-1, 0, 0) * speed);
    }
}
