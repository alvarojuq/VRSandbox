using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderGenerator : MonoBehaviour
{
    public Material[] ingridients;

    public MeshRenderer[] menuItems;

    [SerializeField]
    private int[] order;

    private int random;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < menuItems.Length; i++)
        {
            random = Random.Range(0,5);
            menuItems[i].material = ingridients[random];
            order[i] = random;
        }
    }

    public void ConfirmOrder(Ingridient[] placedItems)
    {
        for(int i = 0; i < order.Length; i++)
        {
            if(order[i] != placedItems[i].ingridientID)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                return;
            }
        }       
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
