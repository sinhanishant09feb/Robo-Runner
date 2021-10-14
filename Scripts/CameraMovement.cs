using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [Header("Player")]
    public Transform player;
    [Range(0.01f,1.0f)]
    public float SmoothFactor = 0.5f;
    private Vector3 camOffset;

    // Start is called before the first frame update
    void Start()
    {
        camOffset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame slightly late from normal update method
    void LateUpdate()
    {
        Vector3 newPos= player.transform.position + camOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
