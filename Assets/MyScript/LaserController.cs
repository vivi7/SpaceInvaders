using UnityEngine;
using System.Collections;

public class LaserController : MonoBehaviour{
	void Start () { }
	void Update () {
		this.transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
		if (this.transform.position.x > 20.0f) {
			Destroy(this.gameObject);        // if not, they run to infinite
		}
	}
}
