<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
	 //movement speed in units per second	
    private float movementSpeed = 40f;
	//public Text text1;

    void Update()
    {
		if(OVRInput.GetDown(OVRInput.Button.Two)){
			SceneManager.LoadScene("openingScene", LoadSceneMode.Single);
		}
		
		GameObject[] allObjects =FindObjectsOfType<GameObject>();
		float x = 0f;
		float z = 0f;
		foreach(GameObject obj in allObjects){
			if(obj.activeInHierarchy){
				if(obj.tag == "CameraRotation"){
					//Checking if primary trigger is pressed down
					if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)){
						//Calculating the x and 'y' distance to travel
						//text1.text = "Angle" + obj.transform.eulerAngles.y;
						x = Convert.ToSingle( movementSpeed * Time.deltaTime * Math.Sin((obj.transform.eulerAngles.y)*Math.PI/180));
						z = Convert.ToSingle( movementSpeed * Time.deltaTime * Math.Cos((obj.transform.eulerAngles.y)*Math.PI/180));
						//Adding those distance to the current position
						transform.position += new Vector3(x,0, z);
					}
				}
				
			}
		}  
		
		
		
    }
	
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
	 //movement speed in units per second	
    private float movementSpeed = 40f;
	//public Text text1;

    void Update()
    {
		if(OVRInput.GetDown(OVRInput.Button.Two)){
			SceneManager.LoadScene("openingScene", LoadSceneMode.Single);
		}
		
		GameObject[] allObjects =FindObjectsOfType<GameObject>();
		float x = 0f;
		float z = 0f;
		foreach(GameObject obj in allObjects){
			if(obj.activeInHierarchy){
				if(obj.tag == "CameraRotation"){
					//Checking if primary trigger is pressed down
					if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)){
						//Calculating the x and 'y' distance to travel
						//text1.text = "Angle" + obj.transform.eulerAngles.y;
						x = Convert.ToSingle( movementSpeed * Time.deltaTime * Math.Sin((obj.transform.eulerAngles.y)*Math.PI/180));
						z = Convert.ToSingle( movementSpeed * Time.deltaTime * Math.Cos((obj.transform.eulerAngles.y)*Math.PI/180));
						//Adding those distance to the current position
						transform.position += new Vector3(x,0, z);
					}
				}
				
			}
		}  
		
		
		
    }
	
}
>>>>>>> ed43fb966578a358e1fc938c8bd4917b4cd7ab35
