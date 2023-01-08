using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ShopItem", menuName = "Custom Data/ShopItem")]
public class ScriptableItem : ScriptableObject
{
    [SerializeField] private int itemID; //might not be needed because the list will have index numbers

    public string itemName;
    public string itemDescription;
    public string itemPrice;
    public Sprite itemImage;

    public int ItemID; //{ get { return itemID; } }

    public void SetItemID (int id)
    {
        
    }

}//class end