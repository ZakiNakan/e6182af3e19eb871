﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public int jump = 0;
    int d = 0;
    int walk = 0;
    GameObject sound; GameObject sound2;
    GameObject walk1; GameObject walk2; GameObject walk3;


    // Use this for initialization
    void Start () {
        walk1 = GameObject.Find("walk1");
        walk2 = GameObject.Find("walk2");
        walk3 = GameObject.Find("walk3");
        walk1.SetActive(false);
        walk2.SetActive(false);
        walk3.SetActive(false);
        sound = GameObject.Find("WJ140 (1)");
        sound2 = GameObject.Find("WJ117 (1)");
        sound2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (transform.position.y < -50 || transform.position.y > 50)
            transform.position = new Vector3(0,3f,0);


        if (Input.GetKeyDown(KeyCode.D) && d == 1  ||  
            Input.GetKeyDown(KeyCode.A) && d == 0)
        {

            if (d == 0) d = 1;
            else d = 0;
        }


        if (d == 0)
            transform.localEulerAngles = new Vector3(0, 0, 0);
        else
            transform.localEulerAngles = new Vector3(0, 180, 0);



        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0.05f, 0, 0));
            if (jump == 0)
            {
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0);
                sound.SetActive(true);
                walk += 1;
                if (walk <= 10)
                { walk1.SetActive(true); walk2.SetActive(false); walk3.SetActive(false); }
                if (walk <= 20 && walk > 10)
                { walk1.SetActive(false); walk2.SetActive(true); walk3.SetActive(false); }
                if (walk <= 30 && walk > 20)
                { walk1.SetActive(false); walk2.SetActive(false); walk3.SetActive(true); }
                if (walk > 30) walk = 0;
            }
            else
                sound.SetActive(false);

        }
        else
        { walk1.SetActive(false); walk2.SetActive(false); walk3.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f,1f);
            sound.SetActive(false);
        }
            
         
            
        if (Input.GetKeyDown(KeyCode.Space) && jump==0)
        {
            jump = 1;
            sound2.SetActive(true);
            GameObject.Find("player").GetComponent<Animation>().Play("rota");

        }
        switch (jump)
        {
            case 0: break;
            case 1:
                gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 300.0f); jump=2;
                break;
            case 2: break;
        }
    }
    void OnCollisionEnter2D(Collision2D other){

        sound2.SetActive(false);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (other.contacts[0].point.y < transform.position.y && (other.gameObject.tag == "rode" || other.gameObject.tag == "box"))
        jump = 0;

    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (gameObject.GetComponent<Rigidbody2D>().mass == 1.5f && other.gameObject.tag == "box")
        {
            if (other.contacts[0].point.x < transform.position.x) other.transform.Translate(Vector3.left * 0.008f, Camera.main.transform);
            else other.transform.Translate(Vector3.right * 0.005f, Camera.main.transform);
        }
    }
}
