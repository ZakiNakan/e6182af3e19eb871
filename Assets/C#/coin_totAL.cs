using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class coin_totAL : MonoBehaviour {

    int total = 0; int a = 0;
	// Use this for initialization
	void Start () {
        for (int j = 1; j < 10; j++)
        {
            a = PlayerPrefs.GetInt("level" + j + "best");
            total += a;
        }
        
        GameObject.Find("coin").GetComponent<Text>().text = " " + total;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
