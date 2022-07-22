using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerMovement : MonoBehaviour
{


    public int maxHealth = 100;
    public int currentHealth;
    private int Items;
    public TMP_Text Itemstext;
    public HealthBar healthBar;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Start() 
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        Items = 0;



    }

    // Update is called once per frame
    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(20);
        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
      
        
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pickup")
        {
            Destroy(collision.GetComponent<GameObject>());
            Items++;
            Itemstext.SetText(Items.ToString());
        }

    }
}
