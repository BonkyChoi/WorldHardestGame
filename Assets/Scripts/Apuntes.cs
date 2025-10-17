using UnityEngine;

public class Apuntes : MonoBehaviour
{
    
    //Application.targetFrameRate = 30;
    //Debug.Log(this.gameObject.transform.position.x);
    //Debug.Log(transform.position.x); se puede poner, es redundante
        
    //this.gameObject.transform.position = new Vector3(5, -1, 0);
    //this.gameObject.transform.rotation = Quaternion.Euler(0, 90, 45);
    //variables
    //serialiazeField: Mostrar variables en inspector
   //[SerializeField] private int numeroA = 5; //private solo accesible desde este sccript
   //[SerializeField] protected string cadena = "hola"; //protected solo accesible desde jerarquia de clases
   //[SerializeField] public bool envenenado = false; //public: desde cualquier punto del programa
   //[SerializeField] float velocidad = 3.6f;
   
   
   [Header("Main stats")]
   [SerializeField] private int vidas;
   [SerializeField] private float velocidad;
   [SerializeField] private string nombre;
   [Header("Energia")]
   [SerializeField] private int energia;
   [SerializeField] private int energiaMax;
   [SerializeField] private int energiaTemp;

   private int numeroRandom;
   private float decimalRandom; 
   
    void Start()
    {
       numeroRandom = Random.Range(0, 100); //entre 0 y 99 (ambos inclusive)
       decimalRandom = Random.Range(-100f, 50f); //entre -100 y 50 (todo inclusive)
       
       Debug.Log(this.gameObject.name);
    }

    
    void Update()
    {
        EjemploInputs();
    }

    void EjemploInputs()
    {
        //Fases de toma de inputs por teclado
        if (Input.GetKeyDown(KeyCode.Space)) //Primer framde de empezar a mantener la tecla
        {
            Debug.Log("Hola Mundo");
        }

        if (Input.GetKey(KeyCode.S)) //Durante todos los frames que mantengas S
        {
            Debug.Log("Hola Mund0");
        }

        if (Input.GetKeyUp(KeyCode.A)) //1er frame en el que se deja de dar al A
        {
            Debug.Log("Hola Mund1");
        }
        
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.position += new Vector3(0, 3f, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += new Vector3(0, -3f, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += new Vector3(-3f, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(3f, 0, 0) * Time.deltaTime;
        }
        
    }
}
