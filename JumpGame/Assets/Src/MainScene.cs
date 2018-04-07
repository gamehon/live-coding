using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum STATE
{
    PLAY = 0,
    GAMEOVER,
    CLEAR,
    END
}

public class MainScene : MonoBehaviour {

    public Animation player;
    public Text scoreLabel;
    public int score = 0;

    public Text timeLabel;
    public float mClearTime = 30;

    public static float mGameTime = 0;

    public STATE mState;

    public Text infoLabel;
    public Animation infoAnimation;

    // Use this for initialization
    void Start () {
        scoreLabel.text = "0";
        timeLabel.text = string.Format("{0}s", mClearTime);
        mState = STATE.PLAY;

        infoLabel.text = "START!";
        infoAnimation.Play();
    }
	
	// Update is called once per frame
	void Update () {
        if (mState == STATE.PLAY)
        {
            mGameTime = Time.deltaTime;
            mClearTime -= mGameTime;
        }
        else
            return;

        if(mClearTime<=0)
        {
            // Clear!
            OnGameClear();
            mClearTime = 0;
        }
        timeLabel.text = string.Format("{0:F1}s", mClearTime);
    }

    public void OnJump()
    {
        player.Play();
        //OnScoreAdd();
    }

    public void OnScoreAdd()
    {
        score += 100;
        scoreLabel.text = score.ToString();
    }

    public void OnGameOver()
    {
        //Time.timeScale = 0;
        mState = STATE.GAMEOVER;
        mGameTime = 0;
        infoLabel.text = "GAME OVER!!!";
        infoAnimation.Play("an_info_gameover");
    }

    public void OnGameClear()
    {
        mState = STATE.CLEAR;
        mGameTime = 0;
        infoLabel.text = "CLEAR!!!";
        infoAnimation.Play("an_info_gameover");
    }
}
