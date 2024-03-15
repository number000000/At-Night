using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookCanvas : MonoBehaviour
{
    public GameObject notebookCanvas;

    // Start is called before the first frame update
    public void Start()
    {
        notebookCanvas.SetActive(false);
    }

    public void OnMouseOver()
    {
        notebookCanvas.SetActive(true);
    }

    public void OnMouseExit()
    {
        notebookCanvas.SetActive(false);
    }
}
