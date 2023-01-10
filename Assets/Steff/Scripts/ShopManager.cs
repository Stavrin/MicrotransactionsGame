using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField] List<ScriptableItem> items;
    [SerializeField] TMPro.TextMeshProUGUI[] itemName, itemDescription, itemPrice;
    [SerializeField] private Image[] itemImage;
    [SerializeField] private TMPro.TextMeshProUGUI wallet;
    
    [SerializeField] ScriptableItem playerWallet;
    [SerializeField] InventoryScriptable playerInventory;
    
    
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < items.Count; i++)
        {
            itemName[i].text = items[i].itemName;
            itemDescription[i].text = items[i].itemDescription;
            itemPrice[i].text = items[i].itemPrice.ToString();
            itemImage[i].sprite = items[i].itemImage;

            wallet.text = playerWallet.ItemID.ToString();
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy(ScriptableItem item)
    {

        if (playerWallet.ItemID - item.itemPrice >= 0)
        {
            playerWallet.ItemID = playerWallet.ItemID - item.itemPrice;
            wallet.text = playerWallet.ItemID.ToString();

            playerInventory.items.Add(item);

        }
        else
        {
            Debug.Log("You don't have enough tokens.");
        }

    }

    public void Play(int money = 10)
    {
        playerWallet.ItemID = playerWallet.ItemID + money;
        wallet.text = playerWallet.ItemID.ToString();
    }

}//class end
