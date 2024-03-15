using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using TMPro;
using static System.String;

public class GrabReset : MonoBehaviour
{
    NotebookGrab notebook; 
    PillowGrab pillow; 
    TabletGrab tablet;
    PillGrab pill;
    TMP_InputField inputfield1;
    TMP_InputField inputfield2;
    TMP_InputField inputfield3;
    TMP_InputField inputfield4;
    TMP_InputField inputfield5;

    private bool flag = false;

    public AudioClip newTrack;

    private int _BlurDistortion = Shader.PropertyToID("_BlurDistortion");
    [SerializeField] private Material _material;

    // Start is called before the first frame update
    void Start()
    {
        notebook = GameObject.FindGameObjectWithTag("Notebook").GetComponent<NotebookGrab>();
        pillow = GameObject.FindGameObjectWithTag("Pillow").GetComponent<PillowGrab>();
        tablet = GameObject.FindGameObjectWithTag("Tablet").GetComponent<TabletGrab>();
        pill = GameObject.FindGameObjectWithTag("Pill").GetComponent<PillGrab>();
        inputfield1 = GameObject.FindGameObjectWithTag("Input1").GetComponent<TMP_InputField>();
        inputfield2 = GameObject.FindGameObjectWithTag("Input2").GetComponent<TMP_InputField>();
        inputfield3 = GameObject.FindGameObjectWithTag("Input3").GetComponent<TMP_InputField>();
        inputfield4 = GameObject.FindGameObjectWithTag("Input4").GetComponent<TMP_InputField>();
        inputfield5 = GameObject.FindGameObjectWithTag("Input5").GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        if(notebook.isGrabbed()){
            _material.SetFloat(_BlurDistortion, 0);
            flag = true;
            AudioManager.instance.PlayCalm(newTrack);
        }
        if(pillow.isGrabbed()){
            _material.SetFloat(_BlurDistortion, 0);
            flag = true;
            AudioManager.instance.PlayCalm(newTrack);
        }
        if(tablet.isGrabbed()){
            _material.SetFloat(_BlurDistortion, 0);
            flag = true;
            AudioManager.instance.PlayCalm(newTrack);
        }
        if(pill.isGrabbed()){
            _material.SetFloat(_BlurDistortion, 0);
            flag = true;
            AudioManager.instance.PlayCalm(newTrack);
        }

        if(!IsNullOrEmpty(inputfield1.text)){
            AudioManager.instance.PlayCalm(newTrack);
        }
        if(!IsNullOrEmpty(inputfield2.text)){
            AudioManager.instance.PlayCalm(newTrack);
        }
        if(!IsNullOrEmpty(inputfield3.text)){
            AudioManager.instance.PlayCalm(newTrack);
        }
        if(!IsNullOrEmpty(inputfield4.text)){
            AudioManager.instance.PlayCalm(newTrack);
        }
        if(!IsNullOrEmpty(inputfield5.text)){
            AudioManager.instance.PlayCalm(newTrack);
        }

        if(_material.GetFloat(_BlurDistortion) > 0.002 && flag){
            AudioManager.instance.PlayStorm();
            flag = false;
        }
    }
}
