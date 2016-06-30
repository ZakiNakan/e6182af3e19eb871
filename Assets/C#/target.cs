using UnityEngine;
using System.Collections;

public class target : MonoBehaviour {

    // Use this for initialization
    GameObject sound;
    void Start () {
        sound = GameObject.Find("得到物品");
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (string.Equals("player", other.gameObject.tag))
        {
            sound.GetComponent<AudioSource>().Play();
            GameObject.Find("level up").GetComponent<coin>().coin_count += 1;
            gameObject.SetActive(false);
        }   
        
            

    }
}
