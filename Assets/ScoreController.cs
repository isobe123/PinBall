using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private GameObject scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {
		
		this.scoreText = GameObject.Find ("ScoreText");

	}
	
	// Update is called once per frame
	void Update () {
		
		if (this.score >= 0) {
			this.scoreText.GetComponent<Text> ().text = ("Score" + this.score);
		}
	}

	void OnCollisionEnter(Collision other){
		

		if (other.gameObject.tag == "SmallStarTag") {
			this.score += 10;
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.score += 20;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			this.score += 15;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			this.score += 30;
		}
			
	}
}
