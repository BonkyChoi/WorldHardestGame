using UnityEngine;

public class Spiral : MonoBehaviour
{
    [SerializeField] private float VelocidadRotacion;
    [SerializeField] private Vector3 DireccionRotacion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(new Vector3(0, 0, 1) * (VelocidadRotacion * Time.deltaTime), Space.Self);
    }
}
