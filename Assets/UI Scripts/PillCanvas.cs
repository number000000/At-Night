using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillCanvas : MonoBehaviour
{
    public GameObject pillCanvas;

    // Start is called before the first frame update
    public void Start()
    {
        pillCanvas.SetActive(false);
    }

    public void OnMouseOver()
    {
        pillCanvas.SetActive(true);
    }

    public void OnMouseExit()
    {
        pillCanvas.SetActive(false);
    }
}
