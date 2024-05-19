using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deploy : MonoBehaviour
{

    [SerializeField] private GameObject inventoryPanel;

    [SerializeField] private bool isDeployed;


    private void Start()
    {
        //Debug.Log(inventoryPanel.transform.position);
    }


    public void DeployUnDeployInventory()
    {
        if(!isDeployed)
        {
            DeployInventory();
            isDeployed = true;
        }
        else if (isDeployed)
        {
            UnDeployInventory();
            isDeployed = false;
        }

    }

    public void DeployInventory()
    {
        inventoryPanel.transform.position = new Vector3(780,inventoryPanel.transform.position.y,0);
    }

    public void UnDeployInventory()
    {
        inventoryPanel.transform.position = new Vector3(-894, inventoryPanel.transform.position.y, 0);
    }


}
