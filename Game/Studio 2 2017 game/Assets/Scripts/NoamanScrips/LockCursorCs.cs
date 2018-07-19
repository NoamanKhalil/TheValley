using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursorCs : MonoBehaviour {

	// Use this for initialization
void Start()
{
	Cursor.lockState = CursorLockMode.Locked;
	Cursor.visible = false;
}
void Update()
{
	Cursor.lockState = CursorLockMode.Locked;
	Cursor.visible = false; }
}
