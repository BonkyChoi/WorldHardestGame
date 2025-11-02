using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] TMP_Text textoscore;
    [SerializeField] float speed = 10f;
    
    private Vector3 PosicionInicial;
    int coins;
    int numberOfCoins;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        PosicionInicial = transform.position;
        numberOfCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    
    private void Movement()
    {
        //Time.deltaTime = por segundo
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");
        
        Vector3 Movement = new Vector3(hInput, vInput, 0f).normalized;
        
        //this.gameObject.transform.position += Movement * (3 * Time.deltaTime);
        
        gameObject.transform.Translate(Movement * (speed * Time.deltaTime), Space.World);
        
    }
    
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            ObtainCoins(other);
        }

        else if (other.gameObject.CompareTag("Trampa"))
        {
            //transform.position = PosicionInicial; 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        else if (other.gameObject.CompareTag("Meta") && coins >= numberOfCoins)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void ObtainCoins(Collider2D other)
    {
        coins++;
        textoscore.text = "Coins: " + coins + " / " + numberOfCoins;
        Destroy(other.gameObject);
        Debug.Log(coins);
        
        
    }
    
}
