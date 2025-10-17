using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] TMP_Text textoscore;
    
    private Vector3 PosicionInicial;
    int coins;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        PosicionInicial = transform.position;
    }

    
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    
    private void Movement()
    {
        //Time.deltaTime = por segundo
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        
        Vector3 Movement = new Vector3(hInput, vInput, 0f).normalized;
        
        //this.gameObject.transform.position += Movement * (3 * Time.deltaTime);
        
        this.gameObject.transform.Translate(Movement * (10f * Time.deltaTime), Space.World);
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            ObtainCoins(other);
        }

        else if (other.gameObject.CompareTag("Aspa"))
        {
            transform.position = PosicionInicial;
        }
    }

    private void ObtainCoins(Collider2D other)
    {
        coins++;
        textoscore.text = "Score: " + coins;
        Destroy(other.gameObject);
        Debug.Log(coins);
    }
}
