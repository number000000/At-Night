using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowCanvas : MonoBehaviour
{
   public GameObject pillowCanvas;

    // Start is called before the first frame update
    public void Start()
    {
        pillowCanvas.SetActive(false);
    }

    public void OnMouseOver()
    {
        pillowCanvas.SetActive(true);
    }

    public void OnMouseExit()
    {
        pillowCanvas.SetActive(false);
    }
}
