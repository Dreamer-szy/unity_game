using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newplayer : MonoBehaviour {

	//获得刚体
	public Rigidbody2D rb;
	public float speed;
	public float jumpforce;
	public Animator anim;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Movement();
	}

	//移动
	void Movement()
    {
		float horizontalmove = Input.GetAxis("Horizontal"); //获得【-1，0】间的所有数
		float facedirection = Input.GetAxisRaw("Horizontal"); //获得-1、0、1三个数

		//移动
		if(horizontalmove != 0)
        {
			rb.velocity = new Vector2(horizontalmove * speed * Time.deltaTime, rb.velocity.y);
			anim.SetFloat("running", Mathf.Abs(facedirection));
        }

		if(facedirection!=0)
        {
			transform.localScale = new Vector3(facedirection, 1, 1);
        }

		//跳跃
		if(Input.GetButtonDown("Jump"))
        {
			rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
        }
    }
}
