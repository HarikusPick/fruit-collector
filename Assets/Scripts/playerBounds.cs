using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBounds : MonoBehaviour
{

  private float minimumX, maximumX;

  // Start is called before the first frame update
  void Start()
  {
    Vector3 coordinate = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    minimumX = -coordinate.x + 1;
    maximumX = coordinate.x - 1;
  }

  // Update is called once per frame
  void Update()
  {
    Vector3 temp = transform.position;

    if (temp.x > maximumX) temp.x = maximumX;
    if (temp.x < minimumX) temp.x = minimumX;

    transform.position = temp;
  }
}
