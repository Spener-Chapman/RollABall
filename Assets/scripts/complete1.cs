using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complete1 : MonoBehaviour
{
    public Transform spawn;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = spawn.transform.position;
    }
}
