using UnityEngine;
using System.Collections;

public class show : MonoBehaviour {

    public string show_what = "";
    public Vector3 show_pos = new Vector3(0,0,0);
    GameObject image;
    public float time = 0; public float a = 1;
	// Use this for initialization
	void Start () {
        image = GameObject.Find("M");
    }
	
	// Update is called once per frame
	void Update () {

       transform.position = show_pos;
        

        if (show_what != "" && time == 0) {
            gameObject.GetComponent<AudioSource>().Play();
            image.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0);
            image = GameObject.Find(show_what);
        }
            


        if (show_what != "")
        {
            time += Time.deltaTime;
            if (time < 2)
            {
                a -= 1 * Time.deltaTime;
                image.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, a);
            }
            else { show_what = ""; a = 1;  time = 0; }
        }
       







    }
}
