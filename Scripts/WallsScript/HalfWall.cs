using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWall : MonoBehaviour
{
    public GameObject Player;
    public GameObject scorP50;
    public GameObject scorM10;
    public GameObject particle;
    public GameObject halfBlast;

    private void OnTriggerEnter(Collider collision)
    {
      
        if (collision.gameObject.tag.Equals("Power"))
        {
            Player.GetComponent<MovementInput>().scor += 50;
            int no = PlayerPrefs.GetInt("HalfWall");
            no++;
            PlayerPrefs.SetInt("HalfWall", no);
            Instantiate(scorP50, this.transform.position, Quaternion.identity);
            Instantiate(particle, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            Instantiate(halfBlast, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        else
        {
            Player.GetComponent<MovementInput>().scor -= 10;
            Instantiate(scorM10, this.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
