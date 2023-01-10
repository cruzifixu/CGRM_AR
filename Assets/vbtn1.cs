using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtn1 : MonoBehaviour
{

    public GameObject btn;
    public Animator anim;

    // Use this for initialization
    void Start()
    {
        btn = GameObject.Find("vbtn_1");
        btn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        btn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        anim.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim.Play("Spin");
        Debug.Log("Button pressed");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        anim.Play("none");
        Debug.Log("Button released");
    }
}