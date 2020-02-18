using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryItem : MonoBehaviour
{
    public InventoryManager manager;
    public string itemName;
    public int quant; // is time cost if action
    public Text nameText, quantText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void HandleAction(string action)
    {
        if (action == "Wait")
        {
            manager.player.timer.AddTime(quant);
        }

        if (action == "Pick Flower")
        {
            manager.player.timer.AddTime(quant);
            manager.player.inventory.AddItem("Flower");
        }
    }

    public void HandleItem(string item)
    {

    }

    public void clicked()
    {
        if(manager.actions)
        {
            HandleAction(itemName);
        } else
        {
            HandleItem(itemName);
        }
    }

}
