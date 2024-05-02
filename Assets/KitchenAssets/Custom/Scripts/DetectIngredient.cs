using System.Collections;
using System.Collections.Generic;

using JetBrains.Annotations;
using Meta.WitAi.Attributes;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using Unity.VisualScripting;
using UnityEngine;

public class DetectIngredient : MonoBehaviour
{
    
    public HandGrabInteractor leftHand;
    public HandGrabInteractor rightHand;
    private int counter = 0;

    private RaycastHit top;
    public Ingridient[] stackedIngridients;

   private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Food")  && counter < 5 )
        {
            Debug.Log("contact");
            leftHand.Unselect();
            rightHand.Unselect();
            other.gameObject.GetComponent<HandGrabInteractable>().enabled = false;
            other.transform.position = transform.position;  
            other.transform.rotation = Quaternion.identity;
            if(Physics.Raycast(transform.position + new Vector3(0,2,0), transform.up, out top))
            {
                 transform.position = top.point;
            }
            
            stackedIngridients[counter] = other.GetComponent<Ingridient>();
            counter++;
        }
   }

   public void Start()
   {
        if(Physics.Raycast(transform.position, transform.up, out top))
            {
                Debug.Log("Object Hit");
                transform.position = top.point;
               
            }
   }
}
