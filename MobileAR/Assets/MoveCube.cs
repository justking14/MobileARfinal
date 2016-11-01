using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {
    public float yValue = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0, yValue, 0);
	}
    
    public void AdjustY(float newY){
        yValue = newY * 5;
    }
}
