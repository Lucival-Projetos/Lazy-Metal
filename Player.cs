using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    private Rigidbody2D corpoRigido;
    public int velocidade = 5;
    
    public Transform peDoPlayer;
    public LayerMask chaoLayer;
    private bool estaNoChao;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private int movendoHash = Animator.StringToHash("movendo");
    
    private void Awake()
    {
        corpoRigido = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            corpoRigido.AddForce(Vector2.up * 600);
        }

        estaNoChao = Physics2D.OverlapCircle(peDoPlayer.position, 0.2f, chaoLayer);

        animator.SetBool(movendoHash, horizontalInput != 0);

        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    private void FixedUpdate()
    {
        corpoRigido.velocity = new Vector2(horizontalInput * velocidade, corpoRigido.velocity.y);
    }
}