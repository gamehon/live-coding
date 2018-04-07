using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSys : MonoBehaviour {

    Vector3 pos;
    // Use this for initialization
    void Start () {
        pos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
        pos.x -= MainScene.mGameTime * 50;
        transform.localPosition = pos;

        if(pos.x < -800)
        {
            pos.x = 800;
        }
	}
}
