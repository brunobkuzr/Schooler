using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour {

    float initialValue;
    public MeshCollider underCollider;
    public GameObject camera;
    int underCount;
    const int underValue = 2;
    int upperCount;
    const int upperValue = 2;
    bool under;
    int toPass;
    public static float timer = 0.0f;
    
  
        // Use this for initialization
      void Start () {
        initialValue = Input.acceleration.y;
        underCount = 0;
        upperCount = 0;
        under = false;
        toPass = 0;
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        float value = Input.acceleration.y;
        if (value < initialValue - 0.7)
        {
            if (underCount < underValue)
            {
                ++underCount;
            }
        }
        else if (value > initialValue + 0.25)
        {
            if (upperCount < upperValue)
            {
                ++upperCount;
            }
        }


        if (under && toPass == 60)
        {
            underCollider.enabled = true;
            toPass = 0;
            under = false;
        }
        if (underCount == underValue)
        {
            under = true;
            transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
            underCollider.enabled = false;
            underCount = 0;
            toPass = 0;
        }

        if (upperCount == upperValue && camera.transform.rotation.x > -15 && camera.transform.rotation.x < 15)
        {
            transform.position = new Vector3(transform.position.x, 4.0f, transform.position.z);
            upperCount = 0;
        }
        ++toPass;
    }


}
