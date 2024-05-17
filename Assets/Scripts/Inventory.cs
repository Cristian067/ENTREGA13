using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }

    [SerializeField] private List<string> inventory = new List<string>();
    [SerializeField] private List<ItemSO> inventoryItems = new List<ItemSO>();

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one instance");
        }

        Instance = this;
    }

    public List<ItemSO> GetInventory()
    {
        return inventoryItems;
    }

    public bool IsItemInInventory(string itemName)
    {
        return inventory.Contains(itemName);
    }

    public void AddItemToInventory(ItemSO itemName)
    {
        inventoryItems.Add(itemName);
    }




}

