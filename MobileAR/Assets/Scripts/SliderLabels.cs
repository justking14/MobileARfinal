using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderLabels : MonoBehaviour {
    public GameObject decadeText;
	// Use this for initialization
	void Start () {
        GameObject canvas = GameObject.Find("SliderCanvas");
        Text fifties = Instantiate(decadeText, canvas.transform.position, transform.rotation) as Text;
        fifties.fontSize = 15;
        fifties.text = "50's";
        fifties.transform.SetParent(canvas.transform, false);

    }

    // Update is called once per frame
    void Update () {
	
	}
}
