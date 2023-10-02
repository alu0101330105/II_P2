using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MantainPersonalSpace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        GameObject cube = GameObject.FindWithTag("Cube");
        GameObject cilinder = GameObject.FindWithTag("Cilinder");

        Vector3 cubePosition = cube.transform.position;
        Vector3 cilinderPosition = cilinder.transform.position;

        double distance = Vector3.Distance(cubePosition, cilinderPosition);
        Debug.Log("Distance between Cube and Cilinder: " + distance);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
