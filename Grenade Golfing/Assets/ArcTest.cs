using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcTest : MonoBehaviour {

    public float forceScale;
    public Vector3 launchForce;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().velocity = launchForce * forceScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
