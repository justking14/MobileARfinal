using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {
    public float yValue = 0f;
    public float cutoffReverse = 0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, yValue, transform.position.z);
	}

    public void AdjustY(float newY) {
        if (newY >= cutoffReverse)
        {
            yValue = (cutoffReverse * 5) + newY * -5;
        }
        else {
            yValue = newY * 5;
        }
    }
}
