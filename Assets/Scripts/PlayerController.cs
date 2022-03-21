using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D bird;

    int score = 0;

    bool dead = false;

	void Start ()
    {
        bird = transform.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown("space") && !dead)
        {
            bird.velocity = new Vector2(0,8.5f);
        }
	}
}
