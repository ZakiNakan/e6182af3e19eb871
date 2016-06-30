using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coin : MonoBehaviour {

    public int coin_count = 0;
    float time = 0;
    bool window = false;
    GameObject a;
    public int best;
    float nextlevel = -1f;

    // Use this for initialization
    void Start () {

       a = GameObject.Find("result");
        a.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        if (nextlevel > 0)
            nextlevel -= Time.deltaTime;
        if (nextlevel > 0 && nextlevel < 1)
            Application.LoadLevel(Application.loadedLevel + 1);

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (string.Equals("player", other.gameObject.tag))
        {
           gameObject.GetComponent<AudioSource>().Play();
            a.SetActive(true);
            best = PlayerPrefs.GetInt(Application.loadedLevelName + "best"); 
            if (coin_count> best)
                PlayerPrefs.SetInt(Application.loadedLevelName + "best", coin_count);
            GameObject.Find("Text_r").GetComponent<Text>().text = "恭喜你获得了" + coin_count + "分\n即将进入下一关";
            nextlevel = 5;

        }



    }

}
