using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformleft : MonoBehaviour
{

    public float speed = 1;
    private int direction = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * direction * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target"))
        {
            direction = -direction;
        }
    }
}
