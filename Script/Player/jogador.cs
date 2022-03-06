using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{

    //movement
    private float input_x, input_y;

    private bool isWalking;

    public float speed;

    public Rigidbody2D rb;

    private Vector2 moveDirection;

    private Vector2 lastMoveDirection;

    //animation
    public Animator animacao;

    // Start is called before the first frame update
    void Start()
    {
        isWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetAxisRaw("Vertical");
        isWalking = (input_x != 0 || input_y != 0);

        if (isWalking)
        {
            var move = new Vector3(input_x, input_y, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            animacao.SetFloat("input_x", input_x);
            animacao.SetFloat("input_y", input_y);
        }

        animacao.SetBool("isWalking", isWalking);
    }
}