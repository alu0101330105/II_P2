using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Vector3 position = transform.position;
        Debug.Log("Position: " + position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
