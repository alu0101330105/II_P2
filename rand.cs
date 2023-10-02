using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class rand : MonoBehaviour {
    public float RangeBot = 0;
    public float RangeTop = 25;
    public int Size = 10;
    public int Value = 15;
    private List<float> arr = new List<float>();

    // Start is called before the first frame update
    void Start() {
        for(int i = 0; i < Size; i++) {
            arr.Add(Random.Range(RangeBot, RangeTop));
        }
    }

    // Update is called once per frame
    void Update() {
        foreach(float number in arr) {
            if(number > Value) Debug.Log(number);
        }

        arr[(int)Random.Range(0, Size)] = Random.Range(RangeBot, RangeTop);
    }
}
