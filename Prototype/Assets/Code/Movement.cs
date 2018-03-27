using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed;


	void Start () {
		
	}
	

	void Update () {
        Moving ();	
	}

    void Moving () {

        float movement = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate (movement, 0, 0);
    }
}
