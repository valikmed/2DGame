using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFactory : MonoBehaviour
{
    private void Start()
    {
        GameObject temp = new GameObject("New Object");
        Destroy(temp, 2);
    }
    
}
