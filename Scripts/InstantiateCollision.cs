<<<<<<< HEAD
﻿using UnityEngine;
public class InstantiateCollision : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public System.Random random = new System.Random();
    public int trashlifetime = 10;

    void OnCollisionEnter()
    {
        Debug.Log(gameObject.name);
        int x = random.Next(100, 300);
        int z = random.Next(100, 300);
        var pos = new Vector3(x, 100, z);
        Instantiate(myPrefab, pos, transform.rotation);
        Destroy(gameObject, trashlifetime);
    }
}
=======
﻿using UnityEngine;
public class InstantiateCollision : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public System.Random random = new System.Random();
    public int trashlifetime = 10;

    void OnCollisionEnter()
    {
        Debug.Log(gameObject.name);
        int x = random.Next(100, 300);
        int z = random.Next(100, 300);
        var pos = new Vector3(x, 100, z);
        Instantiate(myPrefab, pos, transform.rotation);
        Destroy(gameObject, trashlifetime);
    }
}
>>>>>>> ed43fb966578a358e1fc938c8bd4917b4cd7ab35
