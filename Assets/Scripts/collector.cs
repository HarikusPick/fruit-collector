using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
  // Start is called before the first frame update
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "bomb" || other.tag == "fruit")
    {
      Destroy(other.gameObject);
    }
  }
}
