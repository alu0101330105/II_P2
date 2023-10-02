using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    public KeyCode inputKey = KeyCode.Space;
    public Color newColor = new Color(0f,0f,1f,1f);
    private bool state = false;
    private Material material;
    private Color originalColor;

    // Start is called before the first frame update
    void Start() {
        material = GetComponent<Renderer>().material;
        originalColor = material.color;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(inputKey)) {
            state = !state;
        }

        if(state) {
            material.color = newColor;
        } else {
            material.color = originalColor;
        }
    }
}
