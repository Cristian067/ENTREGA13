using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    public static Store Instance { get; private set; }

    [SerializeField] private List<string> store = new List<string>();

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There's more than one instance");
        }

        Instance = this;
    }

    public List<string> GetInventory()
    {
        return store;
    }

    public bool IsItemInInventory(string itemName)
    {
        return store.Contains(itemName);
    }

    public void AddItemToInventory(string itemName)
    {
        store.Add(itemName);
    }

}

