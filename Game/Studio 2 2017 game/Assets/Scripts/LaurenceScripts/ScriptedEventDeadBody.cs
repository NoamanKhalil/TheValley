//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ScriptedEventDeadBody : MonoBehaviour
//{
//    //creted by laurence peat
//    public GameManagerCS gm; 
//    Vector3 pos;
//    bool spawn = false;
//    bool menuopen = false;
//    public GameObject Questmenu;
//    public float distance;

//    public GameObject body;
//    public GameObject player;
//    public GameObject wolfpack;
//    public AudioSource c24audiofile;
//   // public AudioClip dialog1;
//    //static int wolfNum = 5;
//    //public static GameObject[] allFlockers = new GameObject[wolfNum];
//   // public static int RoamSize = 10;



//    // Use this for initialization
//    void Start ()
//    {

        
//        if (gm.mission2 == true)
//      { 
//        pos = new Vector3(0, 0, 0);

        
//        if (menuopen == true)
//        {
//            openQuest();
//        }
//        if (menuopen == false)
//        {
//            closequest();
//        }
//        if (spawn == true)
//        {
//            spawnWolves();
//        }
//      }
//	}

//    // Update is called once per frame
//    void Update()
//    {



//        distance = Vector3.Distance(body.transform.position, player.transform.position);


//        if (distance < 4.0f && Input.GetKeyDown(KeyCode.E))
//        {
//            openQuest();
//            //menuopen = true;
//            //spawn = true;
//        }

//    }


//    public void openQuest ()
//    {

//        CameraControl look = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraControl>();
//        Questmenu.SetActive(true);
//        c24audiofile.Play();
//        Time.timeScale = 0;
//        Cursor.visible = true;
//        Screen.lockCursor = false;
//        look.enabled = false;
//    }

//    public void closequest()
//    {
//        CameraControl look = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraControl>();
//        // Questmenu.SetActive(false);
//        Questmenu.gameObject.SetActive(false);
//        Cursor.visible = false;
//        Screen.lockCursor = true;
//        Time.timeScale = 1;
//        menuopen = false;
//        look.enabled = true;
//        c24audiofile.Pause();
//    }

//    public void spawnWolves()
//    {
//        // for (int i = 0; i < wolfNum; i++)
//        // {
//        //   Vector3 pos = new Vector3(Random.Range(-RoamSize, RoamSize),
//        // Random.Range(-RoamSize, RoamSize),
//        //      Random.Range(-0, 0),
//        //     Random.Range(-RoamSize, RoamSize));
//        //  allFlockers[i] = (GameObject)Instantiate(wolf, pos, Quaternion.identity);
//        //  }
//        wolfpack.gameObject.SetActive(true);


//    }

//}
