using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MyInventory", menuName = "Custom Data/Inventory Data")]
public class InventoryScriptable : ScriptableObject
{
    
    [SerializeField] public List<ScriptableItem> items;
    //public string InventoryName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
