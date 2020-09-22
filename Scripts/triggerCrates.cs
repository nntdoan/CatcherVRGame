<<<<<<< HEAD
﻿using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class triggerCrates : MonoBehaviour
{
    public int counter;
	private static int maxTrash = 5;
    public int counterTrashLimit = maxTrash * 2;
    // public float delayTime = 0;
    private AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider c)
    {		
        counter++;
        audioData.Play();

        if (counter >= counterTrashLimit) 
		{
			// for (int i = 0; i < 20; i++) 
			//{	
			//	float x = (float)200+i*2.5f;
			//	float z = (float)220+i*2.5f;
			//	Instantiate(myPrefabs, new Vector3(x,0,z), Quaternion.identity); 
			//}
			
			SceneManager.LoadScene("winningScene", LoadSceneMode.Single);
		}
    }
		
}

// https://answers.unity.com/questions/564263/change-color-to-multiple-materials-in-one-gameobje.html 
// https://answers.unity.com/questions/1451803/how-to-change-color-on-collision.html
// green  (0, 1, 0, 1), Yellow (1, 0.92, 0.016, 1)
=======
﻿using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class triggerCrates : MonoBehaviour
{
    public int counter;
	private static int maxTrash = 5;
    public int counterTrashLimit = maxTrash * 2;
    // public float delayTime = 0;
    private AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider c)
    {		
        counter++;
        audioData.Play();

        if (counter >= counterTrashLimit) 
		{
			// for (int i = 0; i < 20; i++) 
			//{	
			//	float x = (float)200+i*2.5f;
			//	float z = (float)220+i*2.5f;
			//	Instantiate(myPrefabs, new Vector3(x,0,z), Quaternion.identity); 
			//}
			
			SceneManager.LoadScene("winningScene", LoadSceneMode.Single);
		}
    }
		
}

// https://answers.unity.com/questions/564263/change-color-to-multiple-materials-in-one-gameobje.html 
// https://answers.unity.com/questions/1451803/how-to-change-color-on-collision.html
// green  (0, 1, 0, 1), Yellow (1, 0.92, 0.016, 1)
>>>>>>> ed43fb966578a358e1fc938c8bd4917b4cd7ab35
// if (obj.activeInHierarchy)