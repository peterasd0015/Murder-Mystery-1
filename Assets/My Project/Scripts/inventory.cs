using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventory : MonoBehaviour
{
    public static inventory instance;
    
    [SerializeField] GameObject characterWindow;
    [SerializeField] GameObject InventoryWindow;
    [SerializeField] Transform itensLocation;
    [SerializeField] List<GameObject> itens = new List<GameObject>();

    [SerializeField] TextMeshProUGUI coinsTxt;
    private int coins;

    private void Awake()
    {
        instance = this;
        InventoryWindow.SetActive(false);
        characterWindow.SetActive(false);
        UpdateCoins();

    }
    private void Update()
    {
        Inputs();
    }
    public void OpenCloseInventory() 
    {
        InventoryWindow.SetActive(!InventoryWindow.activeInHierarchy);
    }
    public void OpenCloseCharacter()
    {
        characterWindow.SetActive(!characterWindow.activeInHierarchy);
    }
    private void Inputs()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            OpenCloseInventory();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            OpenCloseCharacter();
        }
    }
public void AddItem(GameObject _item) 
{
        GameObject _newItem = Instantiate (_item, itensLocation.position, itensLocation.rotation, itensLocation);
        itens.Add(_newItem);
}
    public void removeItem(GameObject _item)
    {
        itens.Remove(_item);
        Destroy(_item);
    }
    public void AddCoins(int _value)
    {
        coins += _value;
        UpdateCoins();

    }
    private void UpdateCoins()
    {
        coinsTxt.text = "x"+coins.ToString("00");

    }
}


