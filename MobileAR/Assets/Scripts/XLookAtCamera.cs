using UnityEngine;
using System.Collections;

public class XLookAtCamera : MonoBehaviour {

    Transform t;

	// Update is called once per frame
	void Update () {
        t = Camera.main.transform;
        Vector3 rot = transform.rotation.eulerAngles;
        rot.x=Mathf.Atan((t.position.y - transform.position.y) / (-1*(t.position.z - transform.position.z)))*Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(rot);
	}
}
