using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickupable : MonoBehaviour
{
    private int Items;
    public SpriteRenderer Player;
    public TMP_Text Itemstext;
    

    void Start()
    {
        Items = 0; 
    }

    
        private void OnTriggerEnter2D(Collider2D collision )
        {
            if(collision.tag == "Player")
            {
                      
                 Items++;       
                 Itemstext.SetText(Items.ToString());
                Destroy(gameObject);
            } 
            
        }
 


}
    