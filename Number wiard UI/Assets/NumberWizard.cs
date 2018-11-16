using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	int maxguessallowed = 10;
	 
	public Text text;
	 
	void Start () {
	
	startgame();
	
	}
	
	void startgame() {
	    max = 1000;
	    min = 1;
		nextguess();
		
	
        max = max + 1;	
	}
	
	// Update is called once per frame
	
	public void GuessLower() {
		max = guess;
		nextguess();
	
	}
	
	public void GuessHigher() {
		min = guess;
		nextguess();
	
	}
	
	void nextguess() {
	
		guess = Random.Range (min,max+1);
		text.text = guess.ToString();
		maxguessallowed = maxguessallowed - 1;
		if(maxguessallowed<=0) {
		Application.LoadLevel("win");
		}
	
	}
	
}
