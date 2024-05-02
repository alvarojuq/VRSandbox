using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DestroyFood : MonoBehaviour
{
   
    public String[] typeToDetect;
    
    private void OnTriggerEnter(Collider other) {
        for(int i = 0; i < typeToDetect.Length; i++)
        {
            if(other.gameObject.CompareTag(typeToDetect[i]))
            {
               Destroy(other.gameObject);
            }
        }
        
    }
}
