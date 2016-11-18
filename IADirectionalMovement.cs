using UnityEngine;
using System.Collections;

public class IADirectionalMovement : MonoBehaviour {

	public int speed;
	public int direction;
    public LayerMask layer;

	void Update () {
		Move();
	}

	void Move() {
        float temp = direction * speed * Time.deltaTime;
        Vector3 newPos = transform.position;

        newPos += new Vector3(temp, 0, 0);

        Vector3 testerPos = new Vector3(0,0,0);

        switch (direction)
        {         
            case -1:
                testerPos = transform.Find("LeftTester").transform.position;
                break;
            case 1:
                testerPos = transform.Find("RightTester").transform.position;         
                break;
            default:
                break;
        }

        if (Physics2D.OverlapPoint(testerPos,layer))
        {
            transform.position = newPos;
        }
        else
        {
            direction *= -1;
        }

	}
}
