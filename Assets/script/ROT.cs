using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROT : MonoBehaviour {
    public float min = -0.4f;
    public float max = 0.4f;

    void Start () {
		
	}
	
	void Update () {
        Quaternion rotation = GetComponent<Transform>().rotation;
        rotation.z = Mathf.Clamp(rotation.z,min, max);
        GetComponent<Transform>().rotation = rotation;
        //print(rotation.z);
    }
}
