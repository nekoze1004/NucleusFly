using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class UIController : MonoBehaviour
{
    public GameObject goalButton;
    public GameObject Hand;
    public GameObject clearImg;

    int score = 0;
    int goal = 500;
    GameObject scoreText;
    GameObject gameOverText;
    GameObject debagText;
    GameObject okoText;

    float goalAreaX1 = -1.3f;
    float goalAreaX2 = 1.3f;
    float goalAreaY1 = 4.0f;
    float goalAreaY2 = 2.0f;

	public Boolean isClear = false;
	public Boolean isGameOver = false;

	public Boolean isClearable()
	{
		return score > goal;
	}

    public void AddScore()
    {
		if (!isGameOver) {
			this.score += 10;
		}
    }

    public int ReturnScore()
    {
        return this.score;
    }

    public int ReturnGoal()
    {
        return this.goal;
    }

    public void GameOver()
    {
		if (!isClear) {
			isGameOver = true;
			this.gameOverText.GetComponent<Text> ().text = "GameOver";
		}
    }

	public void GameClear()
	{
		isClear = true;
		Hand.SetActive(false);
		gameOverText.GetComponent<Text>().text = "GameClear";
		clearImg.SetActive(true);
		GameObject.Find ("GameObject").GetComponent<Body_teGenerator> ().CancelInvoke ();
		GameObject[] clones = GameObject.FindGameObjectsWithTag ("hand");
		foreach (GameObject clone in clones) {
			Destroy (clone);
		}
	}

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        this.debagText = GameObject.Find("Debag");
        this.okoText = GameObject.Find("oko");
        this.okoText.GetComponent<Text>().text = "(´・ω・｀)";
        Hand.SetActive(true);
        goalButton.SetActive(true);
		clearImg.SetActive(false);
    }

    void Update()
    {
        //scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");

        //Vector3 fly = GameObject.Find("fly").GetComponent<FlyController>().FlyNow();
        //debagText.GetComponent<Text>().text = fly.ToString();
        //Debug.Log(fly);

        if(score >= goal / 3 * 2)
        {
            okoText.GetComponent<Text>().text = "ヾ(｡｀Д´｡)ﾉ彡";
        }else if(score >= goal / 3)
        {
            okoText.GetComponent<Text>().text = "＼(*｀∧´)／";
        }


		if (score >= goal) {
			goalButton.SetActive (true);
			okoText.GetComponent<Text> ().text = "٩(๑`^´๑)۶";
		}
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
