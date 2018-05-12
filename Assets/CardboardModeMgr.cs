using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;

public class CardboardModeMgr : MonoBehaviour
{

    // We need a reference to camera which 
    // is how we get to the cardboard components.
    public GameObject mainCamera;


    public void Start()
    {
        // Save a flag in the local player preferences to initialize VR mode
        // This way when the app is restarted, it is in the mode that was last used.
        int doVR = PlayerPrefs.GetInt("VREnabled");
        GvrController head = mainCamera.GetComponent<GvrController>();
        head.enabled = true;
    }

    // The event handler to call to toggle Cardboard mode.
    public void ChangeCardboardMode()
    {

        GvrController head = mainCamera.GetComponent<GvrController>();
        head.transform.localRotation = Quaternion.identity;
        
        PlayerPrefs.SetInt("VREnabled", 1);
        PlayerPrefs.Save();
    }
}