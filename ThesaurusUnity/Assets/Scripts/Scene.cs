using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public float timer;   
    public string stime;
    public GUIStyle IntInfoStyle;

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
        //GameObject.Find("Temp").GetComponent<Int Info>().IntInfo = stime;
        //GUI.Label(new Rect(10, 10, 100, 100), stime, IntInfoStyle);
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), stime, IntInfoStyle);
    }
}