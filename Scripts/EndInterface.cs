using UnityEngine;
using System.Collections;
using TMPro;

public class EndInterface : MonoBehaviour {


    public TextMeshProUGUI scoreText;

	// Use this for initialization
	void Start () {

        scoreText.text = "Score: " + GameManager.score;
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
