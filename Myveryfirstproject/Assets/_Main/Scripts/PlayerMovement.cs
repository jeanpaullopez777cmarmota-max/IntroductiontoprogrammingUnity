using UnityEngine;

public class PlayerMovement : MonoBehaviour //this class denotes where we'll carry out all changes to our current script. Monobehaviour is used for adding components on unity's interface
{
    // variables

    [SerializeField] private float _verticalforce = 5f;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody2D.AddForce(Vector2.up * _verticalforce);
        }
        _rigidbody2D.velocity = Vector2.right * _speed * Time.deltaTime;
    }
}
  
