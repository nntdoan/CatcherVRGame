<<<<<<< HEAD
﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class TerrainTrigger : MonoBehaviour
{
    public float colorOffset = 0.2f;
    private int counter =0;
    private static int maxTrash = 15;
	private int highLimitOnCounter = maxTrash * 2;
	private int lowerLimitOnCounter = 10; //5 Cans on ground
    public float delayTime = 0;
    public List<GameObject> listTree;
    private AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
		GameObject[] allObjects = FindObjectsOfType<GameObject>();
		 foreach (GameObject obj in allObjects) 
		 {	 
			if (obj.activeInHierarchy)
			{
				if (obj.tag == "Tree") 
				{
					listTree.Add(obj);
				}
			}
		 }

    }

    void OnTriggerEnter(Collider c)
    {
		Debug.Log(counter);
        counter++;
        audioData.Play();
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

		if (counter <= highLimitOnCounter)
		{
			foreach (GameObject obj in allObjects)
			{
				if (obj.activeInHierarchy)
				{
					
						if (obj.tag == "Tree")
						{   
							Material[] oldMaterials = obj.gameObject.GetComponent<Renderer>().materials;
							// NOTE (if change all material) use foreach (Material mat in oldMaterials) here
							// only change color of the leaves
							// NOTE (if change from the original color) new Color(mat.color.r+counter, oldMaterials[1].color.g-counter, oldMaterials[1].color.b+counter, mat.color.a); mat.color.r + counter, mat.color.a
							oldMaterials[1].color = new Color(oldMaterials[1].color.r + colorOffset, 1 - colorOffset, 0 + colorOffset, 1); 
						}

						else if (obj.tag == "Bush")
						{
							Material[] oldMaterials = obj.gameObject.GetComponent<Renderer>().materials;
							// Bush only has 1 material
							oldMaterials[0].color = new Color(oldMaterials[0].color.r + colorOffset, 1 - colorOffset, 0 + colorOffset, 1);
						}
						

						if (lowerLimitOnCounter < counter && counter <= highLimitOnCounter)
						{
							Destroy(listTree[counter-8]);
							Destroy(listTree[counter-9]);
						}
				}
			}
		}
		else
		{
			SceneManager.LoadScene("losingScene", LoadSceneMode.Single);

		}			
				
			
		
	}

}

// https://answers.unity.com/questions/564263/change-color-to-multiple-materials-in-one-gameobje.html 
// https://answers.unity.com/questions/1451803/how-to-change-color-on-collision.html
// green  (0, 1, 0, 1), Yellow (1, 0.92, 0.016, 1)
=======
﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class TerrainTrigger : MonoBehaviour
{
    public float colorOffset = 0.2f;
    private int counter =0;
    private static int maxTrash = 15;
	private int highLimitOnCounter = maxTrash * 2;
	private int lowerLimitOnCounter = 10; //5 Cans on ground
    public float delayTime = 0;
    public List<GameObject> listTree;
    private AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
		GameObject[] allObjects = FindObjectsOfType<GameObject>();
		 foreach (GameObject obj in allObjects) 
		 {	 
			if (obj.activeInHierarchy)
			{
				if (obj.tag == "Tree") 
				{
					listTree.Add(obj);
				}
			}
		 }

    }

    void OnTriggerEnter(Collider c)
    {
		Debug.Log(counter);
        counter++;
        audioData.Play();
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

		if (counter <= highLimitOnCounter)
		{
			foreach (GameObject obj in allObjects)
			{
				if (obj.activeInHierarchy)
				{
					
						if (obj.tag == "Tree")
						{   
							Material[] oldMaterials = obj.gameObject.GetComponent<Renderer>().materials;
							// NOTE (if change all material) use foreach (Material mat in oldMaterials) here
							// only change color of the leaves
							// NOTE (if change from the original color) new Color(mat.color.r+counter, oldMaterials[1].color.g-counter, oldMaterials[1].color.b+counter, mat.color.a); mat.color.r + counter, mat.color.a
							oldMaterials[1].color = new Color(oldMaterials[1].color.r + colorOffset, 1 - colorOffset, 0 + colorOffset, 1); 
						}

						else if (obj.tag == "Bush")
						{
							Material[] oldMaterials = obj.gameObject.GetComponent<Renderer>().materials;
							// Bush only has 1 material
							oldMaterials[0].color = new Color(oldMaterials[0].color.r + colorOffset, 1 - colorOffset, 0 + colorOffset, 1);
						}
						

						if (lowerLimitOnCounter < counter && counter <= highLimitOnCounter)
						{
							Destroy(listTree[counter-8]);
							Destroy(listTree[counter-9]);
						}
				}
			}
		}
		else
		{
			SceneManager.LoadScene("losingScene", LoadSceneMode.Single);

		}			
				
			
		
	}

}

// https://answers.unity.com/questions/564263/change-color-to-multiple-materials-in-one-gameobje.html 
// https://answers.unity.com/questions/1451803/how-to-change-color-on-collision.html
// green  (0, 1, 0, 1), Yellow (1, 0.92, 0.016, 1)
>>>>>>> ed43fb966578a358e1fc938c8bd4917b4cd7ab35
// 