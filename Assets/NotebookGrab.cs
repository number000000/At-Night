using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NotebookGrab : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private bool Grabbed;

    //[SerializeField] private Color grabbedColor = Color.red;

    private void Start()
    {
        Grabbed = false;

        // Get the XRGrabInteractable component attached to the object
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to the onSelectEnter and onSelectExit events
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        Grabbed = true;
    }


    private void OnRelease(XRBaseInteractor interactor)
    {
        Grabbed = false;
    }

    public bool isGrabbed(){
        return Grabbed;
    }
}
