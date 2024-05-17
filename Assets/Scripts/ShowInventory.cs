using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowInventory : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI inventoryText;
    private string New_Line = "\n";

    // Start is called before the first frame update
    void Start()
    {
        GetShowInventory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void GetShowInventory()
    {
        foreach (string item in Inventory.Instance.GetInventory())
        {
            //if (Inventory.Instance.GetInventory())

            inventoryText.text += item + New_Line;

        }
        //inventoryText.text += Inventory.Instance.GetInventory();
    }

}
