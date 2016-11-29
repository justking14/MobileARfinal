using UnityEngine;
using Vuforia;
using System.Collections;

/*
 * This is a template for a custom trackable event handler
 * Replace the DefaultTrackableEventHandler script with a derivitive of this class
 * Not to be used alone
 */

public class MapTrackableEventHandler : CustomTrackableEventHandler {

    public GameObject slider;

    // Use this for initialization
    void Start() {
        Init();
    }

    protected override void Init() {
        base.Init();
    }

    // Update is called once per frame
    void Update() {
        DoUpdate();
    }

    protected override void DoUpdate() {
        base.DoUpdate();
    }

    protected override void OnTrackingFound() {
        base.OnTrackingFound();
        slider.SetActive(true);
    }

    protected override void OnTrackingLost() {
        base.OnTrackingLost();
        slider.SetActive(false);
    }

}