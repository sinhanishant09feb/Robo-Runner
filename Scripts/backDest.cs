using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backDest : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag.Equals("wall") ||
            collision.gameObject.tag.Equals("Twall"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Des");
        }
    }
}
