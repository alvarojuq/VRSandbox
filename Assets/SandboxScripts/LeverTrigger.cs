using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverTrigger : MonoBehaviour
{

    public UnityEvent leverEvent;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Lever")
        {
           leverEvent.Invoke();
        }
    }
}
