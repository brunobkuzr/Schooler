using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterScript : MonoBehaviour {

    private bool load;

	// Use this for initialization
	void Start () {
        load = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExitButton()
    {
        load = false;
    }

    void EnterGame()
    {
        Application.LoadLevel("GameScene");
    }
}
