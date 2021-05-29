using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    public void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "Ghost1")
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            collision.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }

}
