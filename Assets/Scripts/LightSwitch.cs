using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject mylight1;
    public GameObject mylight2;
    // Start is called before the first frame update
    void Start()
    {
        mylight1 = GameObject.FindGameObjectWithTag("light");
        mylight2 = GameObject.FindGameObjectWithTag("light");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lightSwitching()
    {
        if(mylight1.activeSelf)
        {
            mylight1.SetActive(false);
            mylight2.SetActive(false);
            Debug.Log("OFF");
        }
        else
        {
            mylight1.SetActive(true);
            mylight2.SetActive(true);
            Debug.Log("ON");
        }
    }
}
