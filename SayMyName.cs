using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayMyName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        string name = gameObject.name;
        Debug.Log("I'm " + name);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
