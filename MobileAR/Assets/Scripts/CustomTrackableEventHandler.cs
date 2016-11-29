using UnityEngine;
using Vuforia;
using System.Collections;
using System;

/*
 * This is a template for a custom trackable event handler
 * Replace the DefaultTrackableEventHandler script with a child
 * Not to be used alone
 */

public class CustomTrackableEventHandler: MonoBehaviour, ITrackableEventHandler {

    TrackableBehaviour mTrackableBehavior;

	// Use this for initialization
	void Start () {
        Init();
	}

    protected virtual void Init() {
        mTrackableBehavior = GetComponent<TrackableBehaviour>();

        if (mTrackableBehavior) {
            mTrackableBehavior.RegisterTrackableEventHandler(this);
        }

        OnTrackingLost();
    }
	
	// Update is called once per frame
	void Update () {
        DoUpdate();
	}

    protected virtual void DoUpdate() {

    }

    void SetVisibility(bool visible) {
        Renderer[] rendererComponents = GetComponentsInChildren<Renderer>();

        foreach (Renderer r in rendererComponents) {
            r.enabled = visible;
        }
    }

    protected virtual void OnTrackingFound() {
        SetVisibility(true);
    }

    protected virtual void OnTrackingLost() {
        SetVisibility(false);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus) {
        Debug.Log(newStatus.ToString());
        switch (newStatus) {
            case TrackableBehaviour.Status.TRACKED:
                OnTrackingFound();
                break;
            case TrackableBehaviour.Status.NOT_FOUND:
                OnTrackingLost();
                break;
            default:
                break;

        }
    }
}
