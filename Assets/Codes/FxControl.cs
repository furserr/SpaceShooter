using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxControl : MonoBehaviour {

    Rigidbody fizik;
    public float hiz;

	// Use this for initialization
	void Start () {

        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward*hiz;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
