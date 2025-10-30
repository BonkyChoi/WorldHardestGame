using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] private Vector3 direccionInicial;
    [SerializeField] private float TimeMoving = 2;
    
    private Vector3 direccionActual;

    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direccionActual = direccionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        transform.Translate(direccionActual * (velocidad * Time.deltaTime));
        if (timer >= TimeMoving)
        {
            direccionActual *= -1;
            timer = 0;
        }
    }
}
