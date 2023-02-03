using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMethodMessage : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake:"+ gameObject.name);
    }


    // Start is called before the first frame update
    private void Start()
    {
         Debug.Log("Start:"+ gameObject.name);
       
    }

    // Update is called once per frame
    private void Update()
    {
          Debug.Log("Update:"+ gameObject.name);
      
    }
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update:"+ gameObject.name);
    }
}
