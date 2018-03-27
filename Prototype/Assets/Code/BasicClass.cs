using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasicClass : MonoBehaviour {

    public int classSelected;
    public int moveSpeed;
    public float health;
    public float mana;


	void Start () {
		
	}
	
	void Update () {
		
	}
    public void Attack () {
        if (Input.GetMouseButtonDown (0)) {
        }
    }
}
