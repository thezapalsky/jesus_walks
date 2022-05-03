using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    private Rigidbody rb;
    public float runSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //transform.rotation = Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up); // !!!
    }

    // Update is called once per frame
    void Update()
    {
        //runSpeed+=0.0000001f;
        runSpeed = GameManager.globalSpeed;
        transform.Translate(  new Vector3(0, 0, -1 * runSpeed) );
        

        //rb.AddForce( new Vector3(0, 0, -0.05f) , ForceMode.Impulse);

        if(transform.position.z < -10){
            //Debug.Log("usuwam skurwola");
            Destroy(gameObject);
        }
    }
}
