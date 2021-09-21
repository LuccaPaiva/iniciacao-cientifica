using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualBtn : MonoBehaviour
{
    public GameObject cubeGO, sphereGO;
    VirtualButtonBehaviour vrb;
    // Start is called before the first frame update
    void Start()
    {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);

        vrb = GetComponentInChildren<VirtualButtonBehaviour>();

        vrb.RegisterOnButtonPressed(OnButtonPressed);
        vrb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        cubeGO.SetActive(true);
        sphereGO.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        cubeGO.SetActive(false);
        sphereGO.SetActive(true);
    }
}
