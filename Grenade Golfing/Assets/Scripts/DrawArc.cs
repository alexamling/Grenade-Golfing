using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DrawArc : MonoBehaviour {
    LineRenderer lr;

    public float arcHeight;
    public int resolution;

    // aiming vectors
    public Vector3 target;

    void Awake () {
        lr = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        RenderArc();
	}

    void RenderArc() {
        lr.positionCount = resolution + 1;
        lr.SetPositions(CalculateArcArr());
    }

    Vector3[] CalculateArcArr() {
        Vector3[] arcArr = new Vector3[resolution + 1];
        float xRange = target.x - transform.position.x;
        float zRange = target.z - transform.position.z;
        for (int i = 0; i < arcArr.Length; i++)
        {
            float x = transform.position.x + (xRange / (float)resolution) * i;
            // y = ((-x^2 + xRange * x) * 4 * arcHeight) / xRange^2
            float y = ((-x * x + xRange * x) * 4 * arcHeight) / (xRange * xRange);
            float z =  transform.position.z + (zRange / (float)resolution) * i;
            arcArr[i] = new Vector3(x, y, z);
        }
        return arcArr;
    }
}
