using UnityEngine;
using System.Collections;
public class GameController : MonoBehaviour {
	public GameObject enemy;
	public GameObject laser;
	float spawnTimer;
	float shootTimer;
	void Start () {
		spawnTimer = 1.0f;
	}

	void Update () {
		spawnTimer -= Time.deltaTime;
		shootTimer -= Time.deltaTime;
		if (spawnTimer <= 0.0f) {
			GameObject instance = (GameObject)Instantiate(enemy, new Vector3(15,Random.Range(-4.0f,4.0f), 0.0f), transform.rotation);
			spawnTimer = 1.0f;
		}
		if (shootTimer <= 0.0f) {
			if (Input.GetButton("Fire1")) {
				Vector3 spawnLaserPos = Camera.main.ScreenToWorldPoint(
					new Vector3(-5.0f, Input.mousePosition.y,10));                 
				Instantiate(laser, spawnLaserPos, Quaternion.identity);
				shootTimer = 0.4f;
			}
		}
	}
}
