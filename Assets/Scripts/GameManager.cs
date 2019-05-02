using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager gm;
    public Text winText;
    public 

    // Use this for initialization
    void Start () {

        Application.targetFrameRate = 60;
        winText.text = "";
        if (gm == null)
            gm = gameObject.GetComponent<GameManager>();
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void winGame() {

        winText.text = "You Win";

    }
}
