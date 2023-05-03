using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed;
    private float xInput;
    private float zInput;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        //La valeur en y est 0 car on veut pas que la balle monte ou descend
        Vector3 MoveBall = new Vector3(xInput, 0f, zInput);
        rb.AddForce(MoveBall * Speed);
    }
}