using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShell : MonoBehaviour
{
    float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0 , 0, Time.deltaTime * speed);
    }
}
