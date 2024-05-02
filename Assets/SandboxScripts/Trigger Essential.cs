using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEssential : MonoBehaviour
{
    // Start is called before the first frame update
    public String[] typeToDetect;

    public UnityEvent whenObjectDetected;
    
    private void OnTriggerEnter(Collider other) {
        for(int i = 0; i < typeToDetect.Length; i++)
        {
            if(other.gameObject.CompareTag(typeToDetect[i]))
            {
               whenObjectDetected.Invoke();
            }
        }
        
    }
}
