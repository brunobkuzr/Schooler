using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    public GameObject CongratulationsText;

    // Use this for initialization
    void Start () {
		if(MovementManager.timer != null && MovementManager.timer > 0.0)
        {
            CongratulationsText.active = true;
            Text text = CongratulationsText.GetComponent<Text>();
            text.text = "Parabéns! Vocês terminou em " + (int) MovementManager.timer + " segundos.";
        }
        else
        {
            CongratulationsText.active = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
