using UnityEngine;
using System.Collections;

public class IntroInterface : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    
	}

	public void Click() {
        //set speed
        //restart score
        
        GameManager.globalSpeed = 0.1f;
	    GameManager.score = 0;

		Application.LoadLevel ("SampleScene");
	}
}
