using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class select : MonoBehaviour {

    public Slider a; Vector3 b; GameObject but;
    // Use this for initialization
    Vector2 start;
    void Start () {
       but = GameObject.Find("Button");
       b = but.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

       but.transform.position=(new Vector3(b.x-a.value, b.y, 0));

    }

}
