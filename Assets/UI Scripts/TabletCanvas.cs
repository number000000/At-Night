using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletCanvas : MonoBehaviour
{
    public GameObject tabletCanvas;

    // Start is called before the first frame update
    public void Start()
    {
        tabletCanvas.SetActive(false);
    }

    public void OnMouseOver()
    {
        tabletCanvas.SetActive(true);
    }

    public void OnMouseExit()
    {
        tabletCanvas.SetActive(false);
    }
}
