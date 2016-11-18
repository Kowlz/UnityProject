using UnityEngine;
using System.Collections;

public class DirectionalMovement : MonoBehaviour {

	public int speed;
	public int direction;

	void Update () {
		Move();
	}

	void Move() {
        float temp = direction * speed * Time.deltaTime;
        Vector3 newPos = transform.position;

        newPos += new Vector3(temp, 0, 0);
        transform.position = newPos;

	}
}
