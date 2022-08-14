using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject GameOver;
    public Text health;
    public int healthScore = 3;
    public Transform groundCheck;
    public LayerMask groundMusk;
    private bool ground = false;
    private float groundRadius = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ground = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMusk);
        if (Input.GetMouseButtonDown(0) && ground == true)
        {
            Jump();
        }

        if (healthScore == 0)
        {
            GameOver.SetActive(true);
        }
    }

    private void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            healthScore--;
            health.text = healthScore.ToString();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Demo");
    }
}
