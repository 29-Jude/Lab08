using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionScript : MonoBehaviour
{
    public Text text;
    public float Score;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + Score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "End")
        {
            Destroy(gameObject);
            Score += 1;
        }

        else if(collision.gameObject.tag == "Obstacle")
        {
            Score += 1;
        }
    }
}
