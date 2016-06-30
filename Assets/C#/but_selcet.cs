using UnityEngine;
using System.Collections;

public class but_selcet : MonoBehaviour {

    Vector3 a; GameObject c1; GameObject c2; GameObject c3;
    int coin;
    // Use this for initialization
    void Start () {

        a = GameObject.Find("Button").transform.position;
        c1 = GameObject.Find(gameObject.name+"-1");
        c2 = GameObject.Find(gameObject.name + "-2");
        c3 = GameObject.Find(gameObject.name + "-3");
        coin = PlayerPrefs.GetInt("level"+ gameObject.name + "best");
        if (coin < 1) c1.SetActive(false);
        if (coin < 2) c2.SetActive(false);
        if (coin < 3) c3.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
            gameObject.GetComponent<CanvasRenderer>().SetAlpha((800-Mathf.Abs(transform.position.x - a.x))/100f);
            gameObject.transform.localScale =new Vector3((600 - Mathf.Abs(transform.position.x - a.x)) / 300f, (600 - Mathf.Abs(transform.position.x - a.x)) / 300f, 1f);
        
        if (Mathf.Abs(transform.position.x - a.x) > 450) gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        if (Mathf.Abs(transform.position.x - a.x) > 800) gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

   
}
