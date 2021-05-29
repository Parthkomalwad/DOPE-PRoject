using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBacground : MonoBehaviour
{
    public float speed;
    public float endX;
    public float startX;
    private Vector2 pos;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endX)
        {
            pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
