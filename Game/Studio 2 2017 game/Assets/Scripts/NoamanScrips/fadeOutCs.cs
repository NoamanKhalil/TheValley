using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <Fadeout author>
/// Created by by Noaman khalil ,
/// </summary>
/// used for the fadein effect when the player dies 
public class fadeOutCs : MonoBehaviour
{

	public Image blackScreen;

	void Start()
	{
		blackScreen.canvasRenderer.SetAlpha(0.0f);
	}

	public void FadeIn()
	{
		blackScreen.CrossFadeAlpha(1.0f, 3.0f, true);
	}
}
