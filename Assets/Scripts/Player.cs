using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Player : MonoBehaviour
{
   
    
    public int health = 3;
    
    public TextMeshProUGUI healthDis;
    public GameObject panel;
 
    
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
       
    {

        healthDis.text = health.ToString();
        if (health <= 0)
        {
            panel.SetActive(true);
            Destroy(gameObject);      

        }
       
        



    }
}
