using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ShopItem", menuName = "Custom Data/ShopItem")]
public class ScriptableItem : ScriptableObject
{
    [SerializeField] private int itemID; //might not be needed because the list will have index numbers

    [SerializeField] private string itemName;
    [SerializeField] private string itemDescription;
    [SerializeField] private string itemPrice;
    [SerializeField] private Sprite itemImage;
    
    public int ItemID { get { return itemID; } }

    public void SetItemID (int id)
    {
        
    }

}//class end