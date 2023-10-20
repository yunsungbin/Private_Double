using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    [Header("playerHP")]
    public float maxHP;
    public float curHP;

    public float speed;

    [Header("Jump")]
    public float JumpPower;
    private bool isJump = false;
    [SerializeField]
    private Rigidbody2D rigid;

    [Header("Bullet")]
    public GameObject bullet;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(h, 0);

        transform.position += dir * speed * Time.deltaTime;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJump == false)
        {
            isJump = true;
            rigid.velocity = Vector3.up * JumpPower;
            isJump = false;
        }
    }
}
