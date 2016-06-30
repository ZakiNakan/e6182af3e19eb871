using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 a = GameObject.FindGameObjectWithTag("player").transform.position;
        a.x = (a.x - transform.position.x) / 20 + transform.position.x;
        a.y = (a.y - transform.position.y) / 20 + transform.position.y;
        a.z = -5f;
        transform.position = a;
    }
}
