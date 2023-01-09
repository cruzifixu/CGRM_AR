using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour vb;

    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPress);
        vb.RegisterOnButtonReleased(OnButtonRelease);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress(VirtualButtonBehaviour vb)
    { cube.SetActive(true); }
    public void OnButtonRelease(VirtualButtonBehaviour vb)
    { cube.SetActive(false); }

}
