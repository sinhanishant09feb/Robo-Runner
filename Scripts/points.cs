using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public float lifeTimePoints = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PointsDest());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator PointsDest()
    {
        while(true)
        {
            yield return new WaitForSeconds(lifeTimePoints);
            Destroy(this.gameObject);
        }
    }
}
