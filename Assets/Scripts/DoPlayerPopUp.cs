using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoPlayerPopUp : MonoBehaviour
{

    

    // Use this for initialization
    private void Start()
    {
        this.enabled = false;
        
	}
	
	// Update is called once per frame
	void Update () {
		DoTogglePopUp();
	}

    void DoTogglePopUp()
    {
        if (this.enabled == false)
        {
            this.enabled = true;
        }
        else
        {
           this.enabled = false;
        }
    }
}
