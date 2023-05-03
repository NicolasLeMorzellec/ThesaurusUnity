using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public float timer;   
    public string stime;
    public TextMeshProUGUI Niveau;
    //public GUIStyle IntInfoStyle;

    // Start is called before the first frame update
    void Start()
    {
        timer = 60;
        stime = "60.000";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        stime = timer.ToString("00.000");
        Niveau.SetText(stime);
        //GameObject.Find("Temp").GetComponent<Intinfo>().intinfo = stime;
        //GUI.Label(new Rect(10, 10, 100, 100), stime, IntInfoStyle);
    }
   /* private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), stime, IntInfoStyle);
    }*/
}