<<<<<<< HEAD
﻿using UnityEngine;
public class FirstGenerate : MonoBehaviour
{

    public GameObject myPrefab;
    public System.Random random = new System.Random();
    public int trashlifetime = 120;
    public float InstantiationTimer = 10f;
	public AudioSource audioData;

	
	void Start() 
	{
		audioData = GetComponent<AudioSource>();
		audioData.playOnAwake = false;
	}
		
    void Update()
    {
        CreatePrefab();
    }

    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            int x = random.Next(150, 250);
            int z = random.Next(150, 250);
            var pos = new Vector3(x, 150, z);
            // make rotation random
            GameObject trashClone = Instantiate(myPrefab, pos, transform.rotation);
			audioData.Play();
            InstantiationTimer = 10f;
            Destroy(trashClone, trashlifetime);
        }
    }
}

//  GameObject trashClone = Instantiate(myPrefab, pos, transform.rotation);
=======
﻿using UnityEngine;
public class FirstGenerate : MonoBehaviour
{

    public GameObject myPrefab;
    public System.Random random = new System.Random();
    public int trashlifetime = 120;
    public float InstantiationTimer = 10f;
	public AudioSource audioData;

	
	void Start() 
	{
		audioData = GetComponent<AudioSource>();
		audioData.playOnAwake = false;
	}
		
    void Update()
    {
        CreatePrefab();
    }

    void CreatePrefab()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            int x = random.Next(150, 250);
            int z = random.Next(150, 250);
            var pos = new Vector3(x, 150, z);
            // make rotation random
            GameObject trashClone = Instantiate(myPrefab, pos, transform.rotation);
			audioData.Play();
            InstantiationTimer = 10f;
            Destroy(trashClone, trashlifetime);
        }
    }
}

//  GameObject trashClone = Instantiate(myPrefab, pos, transform.rotation);
>>>>>>> ed43fb966578a358e1fc938c8bd4917b4cd7ab35
