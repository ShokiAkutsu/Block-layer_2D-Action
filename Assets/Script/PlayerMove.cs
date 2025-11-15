using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	[SerializeField] float _speed = 3f;
	Rigidbody2D _rb;
	float _horizontal;

	void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		_horizontal = Input.GetAxisRaw("Horizontal");
	}

	private void FixedUpdate()
	{
		_rb.velocity = new Vector2(_horizontal * _speed, _rb.velocity.y);
	}
}
