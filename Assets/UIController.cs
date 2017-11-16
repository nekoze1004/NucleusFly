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
    int goal = 100;
    GameObject scoreText;
    GameObject gameOverText;
    GameObject debagText;

    float goalAreaX1 = -1.3f;
    float goalAreaX2 = 1.3f;
    float goalAreaY1 = 4.0f;
    float goalAreaY2 = 2.0f;

    public void AddScore()
    {
        this.score += 10;
    }

    public int ReturnScore()
    {
        return this.score;
    }

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }

	public void GameClear()
	{
		Hand.SetActive(false);
		gameOverText.GetComponent<Text>().text = "GameClear";
		clearImg.SetActive(true);
	}

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        this.debagText = GameObject.Find("Debag");
        Hand.SetActive(true);
        goalButton.SetActive(false);
        clearImg.SetActive(false);
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");

        Vector3 fly = GameObject.Find("fly").GetComponent<FlyController>().FlyNow();
        //debagText.GetComponent<Text>().text = fly.ToString();
        //Debug.Log(fly);


        if (score > goal)
        {
            goalButton.SetActive(true);

            if (GameObject.Find("fly") != null)
            {
                

                if ((goalAreaX1 < fly.x) & (fly.x < goalAreaX2) &
                    (goalAreaY1 > fly.y) & (fly.y > goalAreaY2))
                {
					GameClear ();
                    //Application.CaptureScreenshot("unk.png");
                    //DateTime dt = DateTime.Now;

                    //ScreenCapture.CaptureScreenshot(dt.ToString(Application.dataPath + "/yyyyMMddHHmmss") + ".png");

                }
            }
        }
    }
}