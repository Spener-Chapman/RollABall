using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 class level2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider ChangeScene)
    {
        int next = 1;

        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Application.LoadLevelAdditive(next);

        }



    }

}
