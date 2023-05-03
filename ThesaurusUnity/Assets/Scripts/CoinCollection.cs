using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinCollection : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            Destroy(this.gameObject);
            GameObject.Find("Score").GetComponent<Score>().score += 1;
            GameObject.Find("Gestion de Son").GetComponent<AudioSource>().Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}