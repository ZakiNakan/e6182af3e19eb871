using UnityEngine;
using System.Collections;

public class magic : MonoBehaviour {

    public string magicID = ""; 
    int mag = 0; int i = 0;
    float[] time = { 99,99,99,99,99,99};
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (magicID == "M") mag = 1;
        if (magicID == "W") mag = 2;
        if (magicID == "V") mag = 3;
        if (magicID == "triangle") mag = 4;
        if (magicID == "Xing") mag = 5;
        if (magicID == "e") mag = 6;
        if (magicID == "N") mag = 7;
        if (magicID == "S") mag = 8;
        if (magicID == "sum") mag = 9;
        if (magicID == "0") mag = 10;

        if (time[mag] == 99)
            time[mag] = 0;

        function();
        mag = 0; magicID = "";
    }

    void function() {

        time[1] += Time.deltaTime; if (time[1] > 99) time[1] = 99;
        time[2] += Time.deltaTime; if (time[2] > 99) time[2] = 99;
        time[3] += Time.deltaTime; if (time[3] > 99) time[3] = 99;
        time[4] += Time.deltaTime; if (time[4] > 99) time[4] = 99;


        if (time[1] < 3)
                {
                    transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    gameObject.GetComponent<Rigidbody2D>().mass = 0.8f;
                    i = 1;

                }

         if (time[2] < 3)
                {
                    if (time[2] < 1)
                        transform.localScale = new Vector3(time[2] * 1f, time[2] * 1f, time[2] * 1f);
                    else
                        transform.localScale = new Vector3(1f, 1f, 1f);
                    gameObject.GetComponent<Rigidbody2D>().mass = 1.5f;
                    i = 1;
                }
 

         if(time[3] == Time.deltaTime)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 400.0f);
            gameObject.GetComponent<move>().jump = 2;
            gameObject.GetComponent<move_a>().jump = 2;
            time[3] = 99;
        }

        if (time[4] == Time.deltaTime)
        {
            print("1");
            transform.Translate(new Vector3(1f, 0, 0));
            time[4] = 99;
        }

        if (time[1] > 3 && time[2] > 3 || time[1] < 3 && time[2] < 3)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
            if (i == 1)
            {
                gameObject.GetComponent<Animation>().Play("fan");i = 0;
            }
            
            gameObject.GetComponent<Rigidbody2D>().mass = 1f;
            time[1] = 99; time[2] = 99;
        }

    }



}
