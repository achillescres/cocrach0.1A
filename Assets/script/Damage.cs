using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour {
    public int Health;
    public Camera cam;
    public Text text;
	// Use this for initialization
	void Start () {
        Health = 5;

	}
	
	// Update is called once per frame
	void Update () {
		if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
        //print(Health);
        text.text = Health.ToString();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            RecieveDamage();
        }
    }

    void RecieveDamage()
    {
        Health--;
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector3.zero;
        rigid.AddForce(new Vector2(0, 200.0f), ForceMode2D.Impulse);
    }

    /*void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 100), "Health" + Health);
    }*/
}
