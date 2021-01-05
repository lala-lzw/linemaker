using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followme : MonoBehaviour
{

	Rigidbody follew;
	// Use this for initialization
	void Start()
	{
		follew = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{

		//transform.Translate(new Vector3(0.1f, 0.1f, 0.1f));
	}
}