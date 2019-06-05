using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
	public static UiManager instance;
	public GameObject zigZagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text score;
	public Text highScore1;
	public Text highScore2;

    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = "High Score: " + PlayerPrefs.GetInt("highscore").ToString();
    }

	void Awake(){
		if (instance == null){
			instance = this;		
		}
	}

	public void GameStart(){
		tapText.SetActive(false);
		zigZagPanel.GetComponent<Animator>().Play("panelUp");
	}

	public void GameOver(){
		score.text = PlayerPrefs.GetInt("score").ToString();
		highScore2.text = PlayerPrefs.GetInt("highscore").ToString();
		gameOverPanel.SetActive(true);
	}

	public void Reset(){
		SceneManager.LoadScene(0);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
