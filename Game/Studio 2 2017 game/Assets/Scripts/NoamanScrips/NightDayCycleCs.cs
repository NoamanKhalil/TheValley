using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class NightDayCycleCs : MonoBehaviour
{
    public GameObject rainSystem;
    public float time;
    public TimeSpan currentTime;
    public Transform SunTransform;
    public Light sun;
    public Text timeText;
    public int days;

    public float intensity;
    public Color fogday = Color.grey;
    public Color fognight = Color.black;

    public int speed;

	private bool canRain;
	private int randomCountRain;

    void Awake()
    {
        //rainSystem.SetActive(false);
		canRain = false;
    }

    // Update is called once per frame
    void Update()
    {
		randomCountRain = UnityEngine.Random.Range(0, 3);

        ChangeTime();
		rain();
    }

    public void ChangeTime()
    {
        time += Time.deltaTime * speed;

        //24 hours  seconds
        if (time > 86400)
        {
            days += 1;
            time = 0;
        }
        currentTime = TimeSpan.FromSeconds(time);
        string[] temptime = currentTime.ToString().Split(":"[0]); 
//        timeText.text = temptime[0] + "=" + temptime[1]; 

        //21600 is a quater of a day , 360 is degrees , calculates when the sun is above you 
        SunTransform.rotation = Quaternion.Euler(new Vector3((time - 21600) / 86400 * 360, 0, 0)); 

        //checks if its midday and reduces the light 
        if (time < 43200)
        {
            intensity = 1 - (43200 - time) / 43200;

        }
        else
        {
            intensity = 1 - ((43200 - time) / 43200 * -1);
        }
        RenderSettings.fogColor = Color.Lerp(fognight, fogday, intensity * intensity); 

        sun.intensity = intensity;
    }

	void rain()
	{
		if (canRain &&randomCountRain == 1)
		{
			rainSystem.SetActive(false);
		}
	}

	public void PauseRain()
	{
		rainSystem.SetActive(false);
	}
	public void ContinueRain()
	{
		rainSystem.SetActive(true);
	}

}