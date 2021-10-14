using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWall : MonoBehaviour
{
    public GameObject Player;
    public GameObject scorP10;
    public GameObject scorM10;
    public GameObject particle;
    public GameObject redBlast;
    public GameObject scriptManager;


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag.Equals("RedBall"))
        {
            Player.GetComponent<MovementInput>().movFrd = true;
            Player.GetComponent<MovementInput>().scor += 10;
            int no = PlayerPrefs.GetInt("RedWall");
            no++;
            PlayerPrefs.SetInt("RedWall", no);
            Instantiate(scorP10, this.transform.position, Quaternion.identity);
            Instantiate(particle, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            Instantiate(redBlast, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            scriptManager.GetComponent<SpawnWalls1>().chang = true;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            
        }
        else if (collision.gameObject.tag.Equals("Power"))
         {
            Player.GetComponent<MovementInput>().movFrd = true;
            Player.GetComponent<MovementInput>().scor += 10;
            int no = PlayerPrefs.GetInt("RedWall");
            no++;
            PlayerPrefs.SetInt("RedWall", no);
            Instantiate(scorP10, this.transform.position, Quaternion.identity);
            Instantiate(particle, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            Instantiate(redBlast, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            scriptManager.GetComponent<SpawnWalls1>().chang = true;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            
         }

        else if (collision.gameObject.tag.Equals("Player"))
        {
            Player.GetComponent<MovementInput>().InputZ = 0;
            Player.GetComponent<MovementInput>().movFrd = false;
        }
        else
        {
            Player.GetComponent<MovementInput>().scor -= 10;
            Instantiate(scorM10, this.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }      
    }
   
}
