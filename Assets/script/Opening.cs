using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator OpenTheDoor()
    {
        float d = 2.0f;
        yield return new WaitForSeconds(2);
        d = 5.0f;

    }
}
