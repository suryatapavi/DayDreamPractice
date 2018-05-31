using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


    public float PlayerMoveSpeed = 10;
    public float PlayerRotateSpeed = 10;
    // Use this for initialization
    void Start () {
        Debug.Log("Getting Started");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GvrControllerInput.ClickButton)
        {
            this.transform.Translate(this.transform.forward * PlayerMoveSpeed * Time.deltaTime, Space.World);
        }

    }
}
