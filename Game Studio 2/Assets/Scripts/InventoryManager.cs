using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    int counter = 0;
    public bool actions = false;
    public GameObject buttonTemplate;
    public Player player;
    public ArrayList items;
    public GameObject viewport, content;
    public Scrollbar scroll;
    public float buttonHeight = 30;
    // Start is called before the first frame update
    void Start()
    {
        items = new ArrayList();
        if(actions)
        {
           // AddItem("Wait");
        }
    }


    void UpdateItemList()
    {
        scroll.value = 1;
        content.GetComponent<RectTransform>().sizeDelta = new Vector2(0, items.Count*buttonHeight);

        int i = 0;
        while(i < items.Count)
        {
            print("Test");
            InventoryItem item = ((GameObject)items[i]).GetComponent<InventoryItem>();

            if(item.quant <= 0)
            {
                Destroy(item.gameObject);
                items.Remove(item.gameObject);
                continue;
            }

            item.gameObject.transform.position = new Vector3(buttonTemplate.transform.position.x,
                buttonTemplate.transform.position.y - buttonHeight * i,
                item.gameObject.transform.position.x);
            item.quantText.text = item.quant.ToString();
            item.nameText.text = item.itemName;
            i++;
        }

    }


    public void AddItem(string name, int quant = 1)
    {
        print("Adding Item");
        bool preexisting = false;
        for(int i = 0; i<items.Count; i++)
        {
            InventoryItem item = ((GameObject)items[i]).GetComponent<InventoryItem>();
            if(item.itemName == name)
            {
                if(actions)
                {
                    return;
                }
                item.quant+=quant;
                preexisting = true;
                break;
            }
        }

        if(!preexisting)
        {
            GameObject newItem = Instantiate(buttonTemplate);
            newItem.GetComponent<InventoryItem>().itemName = name;
            newItem.GetComponent<InventoryItem>().quant = quant;
            newItem.SetActive(true);
            newItem.transform.SetParent(content.transform);
            items.Add(newItem);
        }
        print("Item Added");
        UpdateItemList();
    }

    public bool RemoveItem(string name, int quant = 1) // returns true on successful removal
    {
        for(int i = 0; i<items.Count; i++)
        {
            InventoryItem item = ((GameObject)items[i]).GetComponent<InventoryItem>();
            if (item.itemName == name)
            {
                if(actions)
                {
                    item.quant = 0;
                    UpdateItemList();
                    return true;
                }

                if(item.quant >= quant)
                {
                    item.quant -= quant;
                    UpdateItemList();
                    return true;
                }
                return false;
            }
        }
        return false;
    }

    public bool RemoveAction(string action)
    {
        return RemoveItem(action);
    }

    public void AddAction(string action, int timeCost)
    {
        AddItem(action, timeCost);
    }

    void TestExample()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            counter++;
            AddItem(counter.ToString(), 2);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            RemoveItem("5", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
