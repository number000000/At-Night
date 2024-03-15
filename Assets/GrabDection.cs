using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabDetection : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    //private Material material;
    private bool Grabbed;
    //private Color originalColor;

    //[SerializeField] private Color grabbedColor = Color.red;

    private void Start()
    {
        Grabbed = false;

        // Get the XRGrabInteractable component attached to the object
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Get the material of the object
        //Renderer renderer = GetComponent<Renderer>();
        //if (renderer != null)
        //{
        //    material = renderer.material;
            //originalColor = material._BlurDistortion;
        //}

        // Subscribe to the onSelectEnter and onSelectExit events
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        // Object is grabbed by the player
        Debug.Log("Object grabbed by player");

        // Change material color when grabbed
        //if (material != null)
        //{
        //    material.SetFloat("_BlurDistortion", 0);
        //}
        Grabbed = true;

    }



    private void OnRelease(XRBaseInteractor interactor)
    {
        // Object is released by the player
        Debug.Log("Object released by player");

        Grabbed = false;
    }

    public bool isGrabbed(){
        return Grabbed;
    }
}
