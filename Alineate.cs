using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using UnityEngine;

public class Alineate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Vector3 spherePosition = transform.position;
        GameObject cubeObject = GameObject.FindWithTag("Cube");
        Vector3 cubePosition = cubeObject.transform.position;
        GameObject cilinderObject = GameObject.FindWithTag("Cilinder");
        Vector3 cilinderPosition = cilinderObject.transform.position;

        // change cube position
        Debug.Log("Cube position before change: " + cubeObject.transform.position);
        cubeObject.transform.position = new Vector3(spherePosition.x - 5, cubePosition.y, cubePosition.z);

        // change cilinder position
        Debug.Log("Cilinder position before change: " + cilinderObject.transform.position);
        cilinderObject.transform.position = new Vector3(spherePosition.x + 5, cilinderPosition.y, cilinderPosition.z);

        
        Debug.Log("Cube position after change: " + cubeObject.transform.position);
        Debug.Log("Cilinder position after change: " + cilinderObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
