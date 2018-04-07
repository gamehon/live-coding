using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public MainScene mainScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        // game over!
        Debug.Log("GameOver!! "+ other.gameObject.name);
        if(other.gameObject.name.Equals("score"))
        {
            mainScene.OnScoreAdd();
        }
        else
            mainScene.OnGameOver();
    }
}
