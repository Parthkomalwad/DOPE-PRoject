using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    private Vector2 targetpos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public GameObject effect;
    public GameObject player1;
    public void UpwardMovements()
    {
        if (player1.transform.position.y < maxHeight)
        {

            Instantiate(effect, player1.transform.position, Quaternion.identity);
            targetpos = new Vector2(player1.transform.position.x, player1.transform.position.y + Yincrement);

        }


    }
    public void DownwardMovements()
    {
        if (player1.transform.position.y > minHeight)
        {
            Instantiate(effect, player1.transform.position, Quaternion.identity);
            targetpos = new Vector2(player1.transform.position.x, player1.transform.position.y - Yincrement);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1.transform.position = Vector2.MoveTowards(player1.transform.position, targetpos, speed * Time.deltaTime);
    }
}
