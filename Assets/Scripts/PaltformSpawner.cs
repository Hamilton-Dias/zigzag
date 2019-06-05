using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaltformSpawner : MonoBehaviour
{
	public GameObject diamond;
	public GameObject platform;
	Vector3 lastPos;
	float size;
	bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = platform.transform.position;
	size = platform.transform.localScale.x;	
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager2.instance.gameOver == true){
		CancelInvoke("SpawnPlatforms");
	}
    }

	public void StartSpawningPlatforms(){
		InvokeRepeating("SpawnPlatforms", 0.5f, 0.2f);	
	}

	void SpawnPlatforms(){
		
		int rand = Random.Range(0, 6);
		if (rand < 3){
			SpawnX();		
		}
		else{
			SpawnZ();		
		}
	}

	void SpawnX(){
		Vector3 pos = lastPos;
		pos.x += size;
		lastPos = pos;
		Instantiate(platform, pos, Quaternion.identity);
		

		int rand = Random.Range(0, 4);
		if(rand < 1){
			pos.y = 1;
			Instantiate(diamond, pos, diamond.transform.rotation);
			pos.y = 0;
		}		


	}

	void SpawnZ(){
		Vector3 pos = lastPos;
		pos.z += size;
		lastPos = pos;
		Instantiate(platform, pos, Quaternion.identity);

		int rand = Random.Range(0, 4);
		if(rand < 1){
			pos.y = 1;
			Instantiate(diamond, pos, Quaternion.identity);
			pos.y = 0;
		}		

	}
}
