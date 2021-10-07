using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public GameObject player;
    
    

    public float cameraDistance = 10.0f;




    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    

    // Update is called once per frame
    void LateUpdate()
    {
       

        transform.position = player.transform.position - player.transform.forward * cameraDistance;
        transform.LookAt(player.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z - 5.0f);
        
    }
}
