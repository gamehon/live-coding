using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSys : MonoBehaviour {
    public float speed = 100;
    Vector3 pos;
	// Use this for initialization
	void Start () {
        pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        pos.x -= MainScene.mGameTime * speed;
        if(pos.x < -1280)
        {
            pos.x = pos.x + 1280;
        }
        transform.localPosition = pos;
	}
}
