using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTrigger : MonoBehaviour
{

    public GameObject barnOutside = null;
    public GameObject canvasObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("entered");
            barnOutside.SetActive(false);
            canvasObject.SetActive(true);
          
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            barnOutside.SetActive(true);
            canvasObject.SetActive(false);
        }
    }

}
