using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float jumpValue = 10;
    //public float m_Speed = 5;
    private Rigidbody rb;
    private bool nearLeftWall = false;
    private bool nearRightWall = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.score++;
        //Debug.Log(GameManager.score);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.1f)
        {
            rb.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A) && !nearLeftWall)
        {   
            rb.AddForce( new Vector3(-0.1f, 0, 0) , ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D) && !nearRightWall)
        {
            rb.AddForce( new Vector3(0.1f, 0, 0) , ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision) {
        
        if(collision.gameObject.tag == "obstacle")
                {
                    GameManager.globalSpeed = 0f;
                    //Debug.Log(GameManager.score);
                    Destroy(gameObject);   
                    Application.LoadLevel ("EndScene");                
                }

        if(collision.gameObject.tag == "fruit")
                {
                    Destroy(collision.gameObject);   
                    GameManager.globalSpeed = GameManager.globalSpeed / 2;
                }

        if(collision.gameObject.tag == "r_wall")
        {
            //Debug.Log("near right wall");
            nearRightWall = true;
        }
        if(collision.gameObject.tag == "l_wall")
        {
            //Debug.Log("near left wall");
            nearLeftWall = true;
        }    
    }
    void OnCollisionExit(Collision collision){
        if(collision.gameObject.tag == "r_wall")
        {
            //Debug.Log("exit - right wall");
            nearRightWall = false;
        }
        if(collision.gameObject.tag == "l_wall")
        {
            //Debug.Log("exit - left wall");
            nearLeftWall = false;
        }
    }
}
