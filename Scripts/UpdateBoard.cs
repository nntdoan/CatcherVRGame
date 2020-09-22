<<<<<<< HEAD
﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBoard : MonoBehaviour {

    public List<GameObject> listBoard;
    public int countTree = 0;
    public int gameLevel = 1;

    // Use this for initialization
    void Start ()
    {
        FindBoard();
    }
	
	// Update is called once per frame
	void Update () 
    {
        GameObject[] allObjectsa = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjectsa)
        {
            if (obj.activeInHierarchy)
            {
                if (obj.tag == "Tree")
                {
                    countTree = countTree + 1;
                }
            }
        }
        

        foreach (GameObject obj in listBoard)
        {
            var menuExist = obj.transform.Find("Canvas/Menu");
            if (menuExist)
            {
                menuExist.GetComponentInChildren<Text>().text = "No. of surviving trees: " + countTree;
            }
        }
        countTree = 0;

    }

    public List<GameObject> FindBoard()
    {
        GameObject[] allObjectsb = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjectsb)
        {
            if (obj.activeInHierarchy)
            {
                if (obj.tag == "Board")
                {
                    listBoard.Add(obj);
                }
            }
        }

        return listBoard;
    }
}
=======
﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBoard : MonoBehaviour {

    public List<GameObject> listBoard;
    public int countTree = 0;
    public int gameLevel = 1;

    // Use this for initialization
    void Start ()
    {
        FindBoard();
    }
	
	// Update is called once per frame
	void Update () 
    {
        GameObject[] allObjectsa = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjectsa)
        {
            if (obj.activeInHierarchy)
            {
                if (obj.tag == "Tree")
                {
                    countTree = countTree + 1;
                }
            }
        }
        

        foreach (GameObject obj in listBoard)
        {
            var menuExist = obj.transform.Find("Canvas/Menu");
            if (menuExist)
            {
                menuExist.GetComponentInChildren<Text>().text = "No. of surviving trees: " + countTree;
            }
        }
        countTree = 0;

    }

    public List<GameObject> FindBoard()
    {
        GameObject[] allObjectsb = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjectsb)
        {
            if (obj.activeInHierarchy)
            {
                if (obj.tag == "Board")
                {
                    listBoard.Add(obj);
                }
            }
        }

        return listBoard;
    }
}
>>>>>>> ed43fb966578a358e1fc938c8bd4917b4cd7ab35
