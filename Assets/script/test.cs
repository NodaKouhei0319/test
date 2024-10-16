using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private int speed;

    private Rigidbody2D rb;

    private Vector2 dir;

    private float x, y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        dir = new Vector2(x, y);

        rb.velocity = dir * speed;
    }
    public void Toto()
    {
        x += 1;
    }
}
