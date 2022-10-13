using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

  [SerializeField]
  private float speed;

  private Animator animator;

  private Rigidbody2D rigidbody2D;

  // Start is called before the first frame update
  private void Start()
  {
    animator = GetComponent<Animator>();
    rigidbody2D = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    Vector2 vector2 = rigidbody2D.velocity;

    vector2.x = Input.GetAxis("Horizontal") * speed;

    rigidbody2D.velocity = vector2;

    animator.SetFloat("speed", Mathf.Abs(vector2.x));

    if (vector2.x < 0) transform.eulerAngles = new Vector3(0, 180, 0);
    else transform.eulerAngles = new Vector3(0, 0, 0);
  }
}
