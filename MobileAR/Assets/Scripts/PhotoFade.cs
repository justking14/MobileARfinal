using UnityEngine;
using System.Collections;

public class PhotoFade : MonoBehaviour {

    public Renderer r;

    private void Start() {
        r = GetComponent<Renderer>();
    }

    public void setBlend(float a) {
        r.material.SetFloat("_Blend", a);
    }

}
