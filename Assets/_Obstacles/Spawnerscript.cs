using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawnerscript : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    float PositionX;
    public float timeLeft = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int obstacle = Random.Range(1, 5);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 1.5f;
            if (obstacle == 1)
            {
                PositionX = Random.Range(1.5f, -1.5f);
                this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
                Instantiate(obstacle1, transform.position, transform.rotation);
            }
            else if (obstacle == 2)
            {
                PositionX = Random.Range(1.5f, -1.5f);
                this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
                Instantiate(obstacle2, transform.position, transform.rotation);
            }
            else if (obstacle == 3)
            {
                PositionX = Random.Range(1.5f, -1.5f);
                this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
                Instantiate(obstacle3, transform.position, transform.rotation);
            }
            else if (obstacle == 4)
            {
                PositionX = Random.Range(1.5f, -1.5f);
                this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
                Instantiate(obstacle4, transform.position, transform.rotation);
            }

        }
        
    }
    

}
