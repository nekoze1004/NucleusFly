using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class UIController : MonoBehaviour
{
    public GameObject goalButton;
    public GameObject Hand;
	public GameObject handGen;
    public GameObject clearImg;

    int score = 0;
    int goal = 500;
    GameObject scoreText;
    GameObject gameOverText;
    // GameObject debagText;
    GameObject okoText;
	GameObject fly;

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
		GameObject.Find ("HandGenerator").GetComponent<Body_teGenerator> ().CancelInvoke ();
		GameObject[] clones = GameObject.FindGameObjectsWithTag ("hand");
		foreach (GameObject clone in clones) {
			Destroy (clone);
		}
	}

    void Start()
    {
		this.scoreText = GameObject.Find("Score");
		this.gameOverText = GameObject.Find("GameOver");
		//this.debagText = GameObject.Find("Debag");
		this.okoText = GameObject.Find("oko");
		this.fly = GameObject.FindGameObjectWithTag ("Player");
		Debug.Log (fly);
		this.handGen = GameObject.Find ("HandGenerator");
		Initialize ();   
    }

	void Initialize()
	{
		Debug.Log ("initialize");
		gameOverText.GetComponent<Text>().text = "";
		this.okoText.GetComponent<Text>().text = "(´・ω・｀)";
		Hand.SetActive(true);
		this.fly.SetActive (true);
		goalButton.SetActive(true);
		clearImg.SetActive(false);
		if (isClear) {
			handGen.GetComponent<Body_teGenerator> ().Start ();
		} else if (isGameOver) {
			GameObject[] clones = GameObject.FindGameObjectsWithTag ("hand");
			foreach (GameObject clone in clones) {
				Destroy (clone);
			}
			handGen.GetComponent<Body_teGenerator> ().CancelInvoke ();
			handGen.GetComponent<Body_teGenerator> ().Start ();
			
		}
		score = 0;
		isClear = false;
		isGameOver = false;
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

		if ((isGameOver || isClear) && Input.GetMouseButtonDown(0)) {
			Initialize ();
		}
    }
}
