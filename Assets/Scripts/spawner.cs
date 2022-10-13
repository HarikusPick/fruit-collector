using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

  [SerializeField]
  private GameObject[] fruits;

  private BoxCollider2D collider2D;

  float left, right;

  // Start is called before the first frame update
  void Start()
  {
    collider2D = GetComponent<BoxCollider2D>();

    left = transform.position.x - collider2D.bounds.size.x / 2f;
    right = transform.position.x + collider2D.bounds.size.x / 2f;

    StartCoroutine(Spawn(1f));
  }

  // Update is called once per frame
  void Update()
  {

  }

  IEnumerator Spawn(float time)
  {
    yield return new WaitForSeconds(time);

    Vector3 temp = transform.position;

    temp.x = Random.Range(left, right);

    Instantiate(fruits[Random.Range(0, fruits.Length)], temp, Quaternion.identity);

    StartCoroutine(Spawn(Random.Range(0.5f, 2f)));
  }
}
