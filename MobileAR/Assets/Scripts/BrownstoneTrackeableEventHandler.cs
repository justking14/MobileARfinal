using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownstoneTrackeableEventHandler : CustomTrackableEventHandler {
    public AudioSource a;
    public AudioClip clip;
    public GameObject slider;

    // Update is called once per frame
    void Update() {
        DoUpdate();
    }

    protected override void DoUpdate() {
        base.DoUpdate();
    }

    protected override void OnTrackingFound() {
        base.OnTrackingFound();
        a.PlayOneShot(clip);
        slider.SetActive(true);
    }

    protected override void OnTrackingLost() {
        base.OnTrackingLost();
        slider.SetActive(false);
        a.Stop();
    }

}
