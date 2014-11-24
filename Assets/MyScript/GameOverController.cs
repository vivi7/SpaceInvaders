using UnityEngine;
using System.Collections;

public class GameOverController : MonoBehaviour{
	float gameOverTimer;
	void Start () {
		gameOverTimer = 5.0f;
	}
	void Update () {
		gameOverTimer -= Time.deltaTime;
		if(gameOverTimer <= 0.0f)
			Application.LoadLevel(0);
	}
}
