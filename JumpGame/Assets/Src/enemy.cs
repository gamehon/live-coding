using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public float speed = 150;
    Vector3 pos;
	// Use this for initialization
	void Start () {
        pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        pos.x -= MainScene.mGameTime * speed;
        if(pos.x<-695)
        {
            pos.x = 700 + Random.Range(0, 100);
        }
        transform.localPosition = pos;
	}
}
