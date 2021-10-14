using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDeActivate : MonoBehaviour
{
    public float lifeTimePoints = 1.5f;

    private void Start()
    {
        StartCoroutine(PointsDest());
    }

    IEnumerator PointsDest()
    {
        while (true)
        {
            yield return new WaitForSeconds(lifeTimePoints);
            this.gameObject.active = false;
        }
    }
}
