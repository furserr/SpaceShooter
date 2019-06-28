using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    Rigidbody fizik;
    Vector3 vec;
    float horizontal = 0;
    float vertical = 0;
    float atesZamani;
    public float atesSuresi;
    public GameObject Kursun;
    public Transform KursunCikisi;
    AudioSource audio;

	// Use this for initialization
	void Start () {

        fizik = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
		
	}

    private void Update()
    {
        
        if(Input.GetButton("Fire1") && Time.time>atesZamani)
        {
            atesZamani = Time.time + atesSuresi;
            Instantiate(Kursun, KursunCikisi.position, Quaternion.identity);
            audio.Play();
        }

    }

    // Update is called once per frame
    void FixedUpdate () {

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec = new Vector3(horizontal, 0, vertical);

        fizik.velocity = vec * 5.0f;

        fizik.position = new Vector3
            (
            Mathf.Clamp(fizik.position.x,-6.0f,6.0f),
            0.0f,
            Mathf.Clamp(fizik.position.z,-4.0f,13.0f)
            );

        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x * -3.0f);
        
		
	}
}
