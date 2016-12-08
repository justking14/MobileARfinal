using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {
    float yValue = 0f;

    public float riseTime = 0f;
    public float fallTime = 0f;

    public float topHeight = 0f;
    public float botHeight = 0f;

    public bool incrementally = true;

	float sinkValue;
    float startY = 0f;

    // Use this for initialization
    void Start () {
		sinkValue = 0.2620398f;
		botHeight = startY - sinkValue;
        startY = transform.localPosition.y;
		topHeight = startY;

        AdjustY(0);
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector3(transform.position.x, startY + yValue, transform.position.z);
        transform.localPosition = new Vector3(transform.localPosition.x, yValue, transform.localPosition.z);

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
                //yValue = -startY * 5.0f;
				yValue = botHeight; //fully down
            }
            /*else if (newY <= riseTime - 0.05f && newY > riseTime - 0.1f)
            {
                //yValue = -startY;
				yValue = topHeight - (sinkValue/2); //a little bit above the ground

            }*/
            else if (newY <= riseTime && newY > riseTime - 0.05f && newY != 0)
            {
				yValue = topHeight -sinkValue; //sets the buildings at half the height

            }
            else if (newY > riseTime)
            {
                yValue = topHeight; //fully up
            }
            else
            {
                yValue = botHeight; //fully down
            }

        }

    }
}
