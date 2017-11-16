using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_teController : MonoBehaviour {

    float fallSpeed;
	public int mode{ get; set; }
	public struct Direction
	{
		public float x,y;
		public Direction(float p1, float p2)
		{
			x = p1;
			y = p2;
		}
	}
	Direction[] direction = new Direction[] {
		new Direction(0f,1f),
		new Direction(0f,-1f),
		new Direction(1f,0f),
		new Direction(-1f,0f)};
	float[] rotate = new float[] {-90, 90, 0, 180};


	// Use this for initialization
	void Start () {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
		transform.Rotate(0, 0, rotate[mode]);

    }
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-fallSpeed * direction[mode].x, -fallSpeed * direction[mode].y, 0, Space.World);

		if(transform.position.y > 6f || transform.position.y < -6f || transform.position.x > 10f || transform.position.x < -10f)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
            Destroy(gameObject);
        }
	}
}
