using UnityEngine;
using System.Collections;

public class button_fuc : MonoBehaviour {

    GameObject bgm; GameObject b;
    float i = 0;
    float a = 0;
    int time = 2;
    bool rest = false; bool start = false; bool back1 = false;
    int total;

    void Start()
    {
        bgm = GameObject.Find("bgm");
        rest = false;
        b = GameObject.Find("puse");
        b.SetActive(false);
    }

    void Update()
    {
        if(rest == true)
        {
            i += Time.deltaTime;
            if (i < time / 2)
                a += 0.5f * Time.deltaTime;
            if (i >= time / 2)
                a -= 0.5f * Time.deltaTime;

            print("1");
            GameObject.Find("shild").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, a);

            if (i > time*0.8)
            {
                rest = false;
                i = 0;
                Application.LoadLevel(Application.loadedLevelName);
                
            }
        }

        if (start == true)
        {
            i += Time.deltaTime;
            if (i < time / 2)
                a += 1f * Time.deltaTime;
            GameObject.Find("back").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, a);

            if (i > time*0.8 )
            {
                rest = false;
                i = 0;
                Application.LoadLevel("select");

            }
        }

        if (back1 == true)
        {
            i += Time.deltaTime;
            if (i < time / 2)
                a += 0.5f * Time.deltaTime;
            if (i >= time / 2)
                a -= 0.5f * Time.deltaTime;
            GameObject.Find("shild").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, a);

            if (i > time)
            {
                back1 = false;
                i = 0;
                Application.LoadLevel("Start");

            }
        }


    }
    public void restart()
    {
        rest = true;
        GameObject.Find("Canvas").SetActive(false);
    }

    public void start1()
    {
        start = true;
        GameObject.Find("Canvas(1)").SetActive(false);
        GameObject.Find("_1").SetActive(false);
        GameObject.Find("_2").SetActive(false);
        GameObject.Find("_3").SetActive(false);
        GameObject.Find("_4").SetActive(false);
        GameObject.Find("_5").SetActive(false);

    }

    public void voice()
	{
        if (bgm.active == true)
        bgm.SetActive(false);
        else
        bgm.SetActive(true);
    }

	public void puse()
	{
        b.SetActive(true);
    }

    public void puse_d()
    {
        b.SetActive(false);
    }

    public void back()
    {
        back1 = true;
        GameObject.Find("Canvas").SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void lodelev1()
    {
        Application.LoadLevel("level1");
    }
    public void lodelev2()
    {
        Application.LoadLevel("level2");
    }
    public void lodelev3()
    {
        Application.LoadLevel("level3");
    }
    public void lodelev4()
    {
        Application.LoadLevel("level4");
    }
    public void lodelev5()
    {
        Application.LoadLevel("level5");
    }
    public void lodelev6()
    {
        Application.LoadLevel("level6");
    }
    public void lodelev7()
    {
        Application.LoadLevel("level7");
    }
    public void lodelev8()
    {
        Application.LoadLevel("level8");
    }
    public void lodelev9()
    {
        Application.LoadLevel("level9");
    }
    public void lodelev10()
    {
        Application.LoadLevel("level10");
    }
}

