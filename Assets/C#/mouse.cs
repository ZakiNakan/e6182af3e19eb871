using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour {

    int i = 0;
    int cl = 0;int cll = 0; int clll = 0;
    float slope = 0; float slopeh = 0;float[] sizefix = { 0,0,0};
    int[] shap = { 0,0,0,0,0,0,0,0,0,0,0 };
    GameObject fix;
    Vector3 position; Vector3 positionh; Vector3 positionn; 
    // Use this for initialization

   
    void Start () {

        transform.position = new Vector3(100f,100f,0);
    }

    // Update is called once per frame
    void Update() {


        if (Input.GetMouseButtonDown(0))
        {

            i = 1;
        }
        if (i == 1) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);//函数是对射线碰撞的检测

            if (gameObject.GetComponent<AudioSource>().isPlaying == false)
            gameObject.GetComponent<AudioSource>().Play();
            position.x = hit.point.x;
        position.y = hit.point.y;
        transform.position = position;

        }
        else
            gameObject.GetComponent<AudioSource>().Stop();
        if (Input.GetMouseButtonUp(0))
        {
            i = 0;
            gameObject.GetComponent<AudioSource>().Stop();
            transform.position = new Vector3(100f, 100f, 0);
        }
    }

    void OnCustomGesture(PointCloudGesture gesture)
    {

        if (gesture.RecognizedTemplate.name != "")
        {
            GameObject.FindGameObjectWithTag("player").GetComponent<magic>().magicID = gesture.RecognizedTemplate.name;
            GameObject.FindGameObjectWithTag("magic show").GetComponent<show>().show_what = gesture.RecognizedTemplate.name;
            GameObject.FindGameObjectWithTag("magic show").GetComponent<show>().time = 0;
            GameObject.FindGameObjectWithTag("magic show").GetComponent<show>().a = 1;
            //GameObject.FindGameObjectWithTag("magic show").GetComponent<show>().show_pos = position;
        }

    }
}
