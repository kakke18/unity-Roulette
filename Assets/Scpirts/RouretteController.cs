﻿using System.Collections;
using UnityEngine;

public class RouretteController : MonoBehaviour {
	float rotSpeed = 0;

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			this.rotSpeed = 10;
		}

		transform.Rotate(0, 0, this.rotSpeed);
		this.rotSpeed *= 0.97f;
	}
}
