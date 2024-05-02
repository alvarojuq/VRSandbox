using System;
using System.Collections;
using System.Collections.Generic;

using JetBrains.Annotations;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using Unity.VisualScripting;
using UnityEngine;
public class ObjectLock : MonoBehaviour
{
    public Transform snapLocation;
    public HandGrabInteractor leftHand;
    public HandGrabInteractor rightHand;

    public String tagToDetect;

    private void Start() {
        
        leftHand = GameObject.Find("HandInteractorsLeft/HandGrabInteractor").GetComponent<HandGrabInteractor>();
        rightHand = GameObject.Find("HandInteractorsRight/HandGrabInteractor").GetComponent<HandGrabInteractor>();
    }

   private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag(tagToDetect))
        {
            leftHand.Unselect();
            rightHand.Unselect();
            other.transform.position = snapLocation.position;  
            other.transform.rotation = Quaternion.identity;
        }
   }
}


