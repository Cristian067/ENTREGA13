using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("w");
        }

        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GetItems()
    {

    }

    public void GetApples()
    {
        List<ItemSO> items = Inventory.Instance.GetInventory();
        foreach (ItemSO item in items)
        {
            item.quantity++;
        }
    }




}
