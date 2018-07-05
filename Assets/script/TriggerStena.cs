using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        enemyAI enem = other.GetComponent<enemyAI>();
        if (other.tag != "player")
        { 
            enem.DirectionPolaris();
        }
        
    }
}
