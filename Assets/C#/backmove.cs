using UnityEngine;
using System.Collections;

public class backmove : MonoBehaviour {

    float i = 0; float j = 4; float rot = 0;
    GameObject a; GameObject b; GameObject c; GameObject d; GameObject e;
    GameObject animal; GameObject plane; GameObject plane1; GameObject plane2;
    // Use this for initialization
    void Start () {
         a = GameObject.Find("_1");
         b = GameObject.Find("_2");
         c = GameObject.Find("_3");
         d = GameObject.Find("_4");
         e = GameObject.Find("_5");
        plane = GameObject.Find("Canvas(1)"); plane1 = GameObject.Find("Button"); plane2 = GameObject.Find("Button (1)"); 
        animal = GameObject.Find("Particle");
        
    }
	
	// Update is called once per frame
	void Update () {
        i += Time.deltaTime;
        j -= Time.deltaTime;

        if (j > 0) {
            GameObject.Find("白").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, j/4);
            plane1.GetComponent<CanvasRenderer>().SetColor(new Color(1f, 1f, 1f, 0));
            plane2.GetComponent<CanvasRenderer>().SetColor(new Color(1f, 1f, 1f, 0));
        }

        if (j < -1 && j > -2)
        {
            plane1.GetComponent<CanvasRenderer>().SetColor(new Color(1f, 1f, 1f, -j-1));
            plane2.GetComponent<CanvasRenderer>().SetColor(new Color(1f, 1f, 1f, -j-1));
        }
            


        if (i < 1)
        {
            a.transform.Translate(new Vector3(0.0008f, -0.00002f, 0));
            b.transform.Translate(new Vector3(0.001f, 0.0005f, 0));
            c.transform.Translate(new Vector3(0.0005f, 0f, 0));
            d.transform.Translate(new Vector3(0.0005f, 0f, 0));
            e.transform.Translate(new Vector3(0.0005f, -0.0001f, 0));
            animal.transform.Translate(new Vector3(0.1f, 0, 0));
        }

        if (i >= 1)
        {
            a.transform.Translate(new Vector3(-0.0008f, 0.0002f, 0));
            b.transform.Translate(new Vector3(-0.001f, -0.0005f, 0));
            c.transform.Translate(new Vector3(-0.0005f, 0f, 0));
            d.transform.Translate(new Vector3(-0.0005f, 0f, 0));
            e.transform.Translate(new Vector3(-0.0005f, 0.0001f, 0));
            animal.transform.Translate(new Vector3(-0.1f, 0, 0));
        }
            
        if (i >= 3)
            i = -1;

        if (Input.acceleration.x > 0.1 || Input.acceleration.x < -0.1)
            transform.Translate(new Vector3(Input.acceleration.x/100, 0, 0));
        if (transform.position.x > 2) transform.position = new Vector3(2, -1, 0);
        if (transform.position.x < -2) transform.position = new Vector3(-2, -1, 0);

    }
}
