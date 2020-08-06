using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolutionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().material.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            gameObject.tag = "Untagged";
            print("clicked");
            print(gameObject.tag);
        }
    }
}
