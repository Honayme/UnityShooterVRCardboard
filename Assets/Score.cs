﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public Text txt;
	public int score;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		txt.text = " " + score; 
	}

	public void updateScore(int temp)
	{
		score += temp; 
	}
}
