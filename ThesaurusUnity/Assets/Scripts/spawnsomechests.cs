using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnsomechests : MonoBehaviour
{
    public GameObject prefabChest;
    public float timer;
    public string stime;
    //add table here to spawn object private
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        stime = "00.000";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            Instantiate(prefabChest, new Vector3(15.0f, 3, 15), Quaternion.identity);
        }
        timer += Time.deltaTime;
        //timer = timer.ToString("00.000"); for txt labels and shit
        stime = timer.ToString("00.000");
    }
}
