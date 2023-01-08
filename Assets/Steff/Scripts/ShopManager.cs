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
    
    
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < items.Count; i++)
        {
            itemName[i].text = items[i].itemName;
            itemDescription[i].text = items[i].itemDescription;
            itemPrice[i].text = items[i].itemPrice;
            itemImage[i].sprite = items[i].itemImage;

            wallet.text = playerWallet.ItemID;
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
