using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCheck : MonoBehaviour
{
    public string scenename;

    private void Update()
    {
        print(GameObject.FindGameObjectsWithTag("correctanswer").Length);

        if (GameObject.FindGameObjectsWithTag("correctanswer").Length <= 0)
        {
            SceneManager.LoadScene(scenename);
            print("scene loaded");
        }
    }
}
