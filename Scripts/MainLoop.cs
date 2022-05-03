using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoop : MonoBehaviour
{
    public GameObject[] obstacles = new GameObject[2];
    public GameObject fruitModel;

    public float minX = -10.0f, maxX = 10.0f;
    public float minZ = 50.0f, maxZ = 450.0f;
    public float minTime = 0f, maxTime = 2f;

    private bool enableObstacles = true;
	private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateObstacles());
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.score%1000==0){
            //Debug.Log("ogien++");
            GameManager.globalSpeed =  GameManager.globalSpeed + GameManager.globalSpeed * 0.1f;
        }
    }

    IEnumerator GenerateObstacles()
	{
        yield return new WaitForSeconds(0f);

		while(enableObstacles) {

		// 	if (GameManager.currentNumberStonesThrown == 20)
		// 		Application.LoadLevel("EndScreen");
            //Debug.Log("generuje skurwola");

            if(Random.Range(0, 10) < 1){
                GameObject fruit = (GameObject) Instantiate(fruitModel);
                fruit.transform.position = new Vector3(Random.Range(minX, maxX),
                                                        0.0f, 
                                                        Random.Range(minZ, maxZ)); 
            }

			GameObject obstacle = (GameObject) Instantiate(obstacles[Random.Range(0, obstacles.Length)]);
            obstacle.transform.position = new Vector3(Random.Range(minX, maxX),
                                                        0.0f, 
                                                        Random.Range(minZ, maxZ)); 
                                                        
		    yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            //yield return new WaitForSeconds(30);
			
		}
		
    }
}
