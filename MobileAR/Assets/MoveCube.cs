using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {
    float yValue = 0f;

    public float riseTime = 0f;
    public float fallTime = 0f;

    public bool incrementally = true;

    float startY = 0f;

    // Use this for initialization
    void Start () {
        

        startY = transform.position.y;
        AdjustY(0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, startY + yValue, transform.position.z);
	}

    public void AdjustY(float newY) {
        Debug.Log(newY);

        if (incrementally == false)
        {
            if (newY > fallTime)
            {
                yValue = -startY * 5.0f;
            }
            else if (newY > riseTime)
            {
                yValue = 0;
            }
            else
            {
                yValue = -startY * 5.0f;
            }
        }
        else {
            if (newY > fallTime)
            {
                yValue = -startY * 5.0f;
            }
            else if (newY <= riseTime - 0.05f && newY > riseTime - 0.1f)
            {
                yValue = -startY;
            }
            else if (newY <= riseTime && newY > riseTime - 0.05f)
            {
                yValue = -startY / 2.0f;

            }
            else if (newY > riseTime)
            {
                yValue = 0;
            }
            else
            {
                yValue = -startY * 5.0f;
            }

        }

    }
}
