using UnityEngine;
using System.Collections;
public class EnemyController : MonoBehaviour{
	public GameObject explosion;
	public GameObject laser;
	public float speed;
	void Start () {	}
	void OnCollisionEnter(Collision other) {   //unity method
		print ("on collision");
		if (other.gameObject.tag.Equals("Laser")) {
			print("on collision if");
			Destroy(other.gameObject);
			Destroy(this.gameObject);
			Instantiate(explosion, this.transform.position, this.transform.rotation);
		}
	}
	void Update () {
		this.transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
		if (this.transform.position.x <= -15.0f) {
			GameOver();
		}
	} 
	void GameOver(){ 
		Application.LoadLevel(1);  
	}  //change scene
}
