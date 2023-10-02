using System;
using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using UnityEngine;

public class Balls : MonoBehaviour {

    public String affectedTag = "tag";
    public KeyCode inputKey = KeyCode.Space;
    public float HueShift = 0.1f;
    public float PositionShift = 1;
    private GameObject closest;
    private GameObject farthest;
    private GameObject[] gameObjects;

    // Start is called before the first frame update
    void Start() {
        gameObjects = GameObject.FindGameObjectsWithTag(affectedTag);
        float minDist = float.PositiveInfinity;
        float maxDist = 0;

        foreach(GameObject ball in gameObjects) {
            if(Vector3.Distance(transform.position, ball.transform.position) < minDist) {
                closest = ball;
                minDist = Vector3.Distance(transform.position, ball.transform.position);
            }
            if(Vector3.Distance(transform.position, ball.transform.position) > maxDist) {
                farthest = ball;
                maxDist = Vector3.Distance(transform.position, ball.transform.position);
            }
        }
        
        Debug.Log("Starting closest: " + closest.name);
        Debug.Log("Starting farthest: " + farthest.name);
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(inputKey)) {
            
            UpdateBalls();

            ColorChange();

            MoveBall();

        }
    }

    void UpdateBalls() {
        float minDist = Vector3.Distance(transform.position, closest.transform.position);
        float maxDist = Vector3.Distance(transform.position, farthest.transform.position);

        foreach(GameObject ball in gameObjects) {
            if(Vector3.Distance(transform.position, ball.transform.position) < minDist) {
                closest = ball;
                minDist = Vector3.Distance(transform.position, ball.transform.position);
            } else if(Vector3.Distance(transform.position, ball.transform.position) > maxDist) {
                farthest = ball;
                maxDist = Vector3.Distance(transform.position, ball.transform.position);
            }
        }
    }

    void ColorChange() {
        Color currentColor = farthest.GetComponent<Renderer>().material.color;
        float H, S, V; H = S = V = 0;
        Color.RGBToHSV(currentColor, out H, out S, out V);
        Debug.Log("Original color = " + currentColor);
        Debug.Log(H + ", " + S + ", " + V);
        H += HueShift;
        if(H > 1f) H -= 1f;
        Debug.Log(H + ", " + S + ", " + V);
        Color newColor = Color.HSVToRGB(H, S, V);
        Debug.Log("New color: " + newColor);
        farthest.GetComponent<Renderer>().material.color = newColor;
    }

    void MoveBall() {
        Vector3 position = closest.transform.position;
        closest.transform.position = new Vector3(position.x, position.y + PositionShift, position.z);
    }
}
