using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowInventory : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI inventoryText;
    private string New_Line = "\n";

    public static ShowInventory Instance {  get; private set; }


    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Error, Showinventory more than 1");
            
        }

        Instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {
        RefreshInventory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public void GetShowInventory()
    {
        //foreach (string item in Inventory.Instance.GetInventory())
        //{
            //if (Inventory.Instance.GetInventory())

            //inventoryText.text += item + New_Line;

        //}
        foreach(ItemSO item in Inventory.Instance.GetInventory())
        {
            if(item.quantity != 0)
            {
                inventoryText.text += item.itemName + item.quantity + New_Line;
            }
            
        }


        //inventoryText.text += Inventory.Instance.GetInventory();
    }*/

    public void RefreshInventory()
    {
        inventoryText.text = null;
        foreach (ItemSO item in Inventory.Instance.GetInventory())
        {
            if (item.quantity != 0)
            {
                inventoryText.text += item.name + ": " + item.quantity + New_Line;
            }

        }
    }


}
