using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove1 : MonoBehaviour
{
    public float moveSpeed;
    void Update()
    {
        if (PlayerHit1.HP >= 66)
            moveSpeed = 5f;
        if (PlayerHit1.HP < 66 && PlayerHit1.HP >= 33)
            moveSpeed = 6f;
        if (PlayerHit1.HP < 33)
            moveSpeed = 7f;
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 moveVelocity = new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;
        this.transform.position += moveVelocity;

        if (x == -1)
            transform.localScale = new Vector3(-1f, 1f, 1f);
        if (x == 1)
            transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
