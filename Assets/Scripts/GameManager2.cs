﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

	public static GameManager2 instance;
	public bool gameOver;

	void Awake(){
		if(instance == null){
			instance = this;
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void StartGame(){
		UiManager.instance.GameStart();
		ScoreManager.instance.StartScore();
		GameObject.Find("PlatformSpawner").GetComponent<PaltformSpawner>().StartSpawningPlatforms();
	}

	public void GameOver(){
		UiManager.instance.GameOver();
		ScoreManager.instance.StopScore();
		gameOver = true;
	}
}
