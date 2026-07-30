using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // variables
    

    public float _fuerza = 2000f;

    [SerializeField] private Rigidbody2D _rigidbody2D;




    // Start is called before the first frame update
    void Start() //execute only once, it just executes a single frame 
    {
        _rigidbody2D.AddForce(Vector2.right * _fuerza);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
