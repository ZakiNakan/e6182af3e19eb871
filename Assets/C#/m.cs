using UnityEngine;
using System.Collections;

public class m : MonoBehaviour {

    public int time=5;
    float i = 0;
    float a = 0;

    void Start()
    {
        for(int j = 1; j < 10; j++)
        {
            if (!PlayerPrefs.HasKey("level" + j + "best"))
                PlayerPrefs.SetInt("level" + j + "best", 0);
        }
       
    }

    void Update()
    {
        i += Time.deltaTime;
        if (i < time / 2)
            a += 1 * Time.deltaTime;
        if (i >= time / 2)
            a -= 1 * Time.deltaTime;
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,a);

        if (i > time)

            Application.LoadLevel("Start");

    }

}