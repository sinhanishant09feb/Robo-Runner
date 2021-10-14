using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public Rigidbody ball;

    private float smooth;
    private float DistPerFrame;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        ball.AddForce(0, 0, 800);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<MovementInput>().InputZ >= 0.99)
        {
            this.transform.Translate(0f * Time.deltaTime, 0f * Time.deltaTime,
            40 * Time.deltaTime, Space.World);
        }
        ball.AddForce(0, 0, 100);
    }
}
