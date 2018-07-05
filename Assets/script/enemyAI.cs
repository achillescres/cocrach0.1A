using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour {
    private Vector3 direction;
    public int dir = 1;
    private int i;
    private bool t;
    private float speed = 2.0f;
	// Use this for initialization
	void Start () {
		
	}

    public void DirectionPolaris()
    {
        dir *= -1;
        t = true;
    }
	
	// Update is called once per frame
	void Update () {
        direction = transform.right;
        transform.position = Vector3.MoveTowards(transform.position, transform.position - direction, speed * Time.deltaTime * dir);

        if (t)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1 , transform.localScale.y, transform.localScale.z);
            t = false;
        }
        if (transform.rotation.z*100 < -60)
        {
            Destroy(this.gameObject);
        }

        if (transform.rotation.z*100 > 60)
        {
            Destroy(this.gameObject);
        }
        Debug.Log(transform.rotation.z);


    }

    /*void CheckPlayer()
    {
        Collider2D collider = Physics2D.OverlapCircle(new Vector2(transform.position.x - 0.55f, transform.position.y), 0.35f, 1);
        Debug.Log(collider);
    }*/
}
