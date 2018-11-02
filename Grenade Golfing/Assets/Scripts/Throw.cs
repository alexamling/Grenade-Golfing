using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

    public ArcTest throwable;
    public float throwForce;

    LineRenderer lr;

	// Use this for initialization
	void Start () {
        lr = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ArcTest thrownObject = Instantiate(throwable, lr.GetPosition(0), Quaternion.identity);
            thrownObject.forceScale = throwForce;
            thrownObject.launchForce = lr.GetPosition(1) - lr.GetPosition(0);
        }
	}
}
