using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenWall : MonoBehaviour
{
    public Material Yellow;
    public Material Blue;
    private Renderer rend;
    public int col = 0;
    public GameObject Player;
    public GameObject scorP10;
    public GameObject scorP20;
    public GameObject scorM20;
    public GameObject particle;
    public GameObject greenBlast;
    public GameObject scriptManager;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("BlackBall"))
        {
            col++;
            if (col == 1)
            {
                Player.GetComponent<MovementInput>().scor += 10;
                Instantiate(scorP10, this.transform.position, Quaternion.identity);
            }

            else if (col == 2)
            {
                Player.GetComponent<MovementInput>().scor += 20;
                Instantiate(scorP20, this.transform.position, Quaternion.identity);
            }
            Destroy(collision.gameObject);
            rend.sharedMaterial = Blue;
        }

        if (collision.gameObject.tag.Equals("BlueBall"))
        {
            col++;
            if (col == 1)
            {
                Player.GetComponent<MovementInput>().scor += 10;
                Instantiate(scorP10, this.transform.position, Quaternion.identity);
            }
            else if (col == 2)
            {
                Player.GetComponent<MovementInput>().scor += 20;
                Instantiate(scorP20, this.transform.position, Quaternion.identity);
            }
            Destroy(collision.gameObject);
            rend.sharedMaterial = Yellow;
        }

        if (collision.gameObject.tag.Equals("Power"))
        {
            Player.GetComponent<MovementInput>().movFrd = true;
            Player.GetComponent<MovementInput>().scor += 20;
            int no = PlayerPrefs.GetInt("GreenWall");
            no++;
            PlayerPrefs.SetInt("GreenWall", no);
            Instantiate(scorP20, this.transform.position, Quaternion.identity);
            scriptManager.GetComponent<SpawnWalls1>().chang2 = true;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag.Equals("RedBall"))
        {
            Player.GetComponent<MovementInput>().scor -= 20;
            Instantiate(scorM20, this.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag.Equals("Player"))
        {
            Player.GetComponent<MovementInput>().InputZ = 0;
            Player.GetComponent<MovementInput>().movFrd = false;
        }


    }

    public void Update()
    {
        if (col == 2)
        {
            Player.GetComponent<MovementInput>().movFrd = true;
            int no = PlayerPrefs.GetInt("GreenWall");
            no++;
            PlayerPrefs.SetInt("GreenWall", no);
            Instantiate(particle, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            Instantiate(greenBlast, new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.z), Quaternion.identity);
            scriptManager.GetComponent<SpawnWalls1>().chang2 = true;
            Destroy(this.gameObject);
        }
    }
}
