using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    private Rigidbody rb;
    public float runSpeed;
    public GameObject water;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //runSpeed+=0.0000001f;
        runSpeed = GameManager.globalSpeed;
        //GameManager.globalSpeed+=0.001f;
        
        transform.Translate(  new Vector3(0, 0, -1 * runSpeed) );
        //rb.AddForce( new Vector3(0, 0, -0.05f) , ForceMode.Impulse);

        //Debug.Log(transform.position.z);
        if(transform.position.z < - 250){
            //Debug.Log("robie wode nowa");
            //Instantiate(water);
            transform.Translate( 0,0,250);
            //Destroy(gameObject);
        }
        
    }
}
