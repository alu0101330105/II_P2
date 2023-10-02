using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Vector3 vector1 = new Vector3(0, 1, 0);
    public Vector3 vector2 = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start() {
        double magnitude1 = vector1.magnitude;
        Debug.Log("Magnitude of Vector 1: " + magnitude1);
        double magnitude2 = vector2.magnitude;
        Debug.Log("Magnitude of Vector 2: " + magnitude2);

        double angle = Vector3.Angle(vector1, vector2);
        double distance = Vector3.Distance(vector1, vector2);
        Debug.Log("Angle between Vector 1 and Vector 2: " + angle);
        Debug.Log("Distance between Vector 1 and Vector 2: " + distance);

        if(vector1.y > vector2.y) {
            Debug.Log("Vector 1 is higher than Vector 2");
        } else if(vector1.y < vector2.y) {
            Debug.Log("Vector 2 is higher than Vector 1");
        } else {
            Debug.Log("Vector 1 and Vector 2 are at the same height");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
