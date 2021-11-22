using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        // ѕерев≥р€Ї чи м'ч рухаЇтьс€ в напр€мку ракетки коли х позитивне значенн€ або в≥д ракетки коли х негативне
        if (this.ball.velocity.x > 0.0f)
        {
            // ѕерем≥щуЇ ракетку ≥ сл≥дкуЇ за м'€чем
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            // ѕерем≥щамЇ ракетку у центр доти пок≥ м'€ч не полетить до нењ
            if (this.ball.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this.speed / 10);
            }
            else if (this.ball.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this.speed / 10);
            }
        }
    }
}