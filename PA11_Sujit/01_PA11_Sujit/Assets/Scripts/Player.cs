using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed;
    public static float Score;
    public Text Txt_Score;
    public static Player thisplay;
    // Start is called before the first frame update
    void Start()
    {
        thisplay = this;
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.Translate(0f, verticalInput, 0f);

        Vector3 clampedPosition = transform.position;

        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -4, 4);

        transform.position = clampedPosition;

       /* transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
        float xPos = Mathf.Clamp(transform.position.y, 4, -4);
        transform.position = new Vector3(transform.position.x, xPos, transform.position.z);*/
      

    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Obstacle")
        {
            Time.timeScale = 0;
        }
    }*/
    public void UpdateScore()
    {
        Score++;
        Txt_Score.text = "Score : " + Score;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Obstacle")
        {
            SceneManager.LoadScene(1);
        }
    }
}
