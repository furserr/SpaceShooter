using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    Rigidbody fizik;
    public float hiz;

	// Use this for initialization
	void Start () {

        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere * hiz;
		
	}
	

}
