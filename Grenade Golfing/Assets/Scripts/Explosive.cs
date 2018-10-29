using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour {

    public GameObject Player;
    public float Delay;
    public float Power;
    public float Radius;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Delay -= Time.deltaTime;
        if(Delay <= 0)
        {
            Explode();
        }
	}

    void Explode()
    {
        Player.GetComponent<Rigidbody>().AddExplosionForce(Power, transform.position, Radius, -.5f);
        Destroy(gameObject);
    }
}
