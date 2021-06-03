using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Collider2D coll;

    Collider2D preventCollider;
    Rect latestBorder;

    public void Initialize(Rect border)
    {
        preventCollider = BallMovement.Instance.coll;
        spriteRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<Collider2D>();

        latestBorder = border;

        Reposition();
    }

    public void Reposition()
    {
        float x = Random.Range(latestBorder.x, latestBorder.x + latestBorder.width);
        float y = Random.Range(latestBorder.y, latestBorder.y + latestBorder.height);

        Vector3 newPos = new Vector2(x, y);

        if (preventCollider.OverlapPoint(newPos))
        {
            // acak lagi
            Reposition();
            return;
        }

        transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ScoreManager.AddScore();
            DestroyThenRevive();
        }
    }

    private void DestroyThenRevive()
    {
        spriteRenderer.enabled = false;
        coll.enabled = false;
        StartCoroutine(ReviveAfter(3.0f));
    }

    private IEnumerator ReviveAfter(float time)
    {
        yield return new WaitForSeconds(time);
        spriteRenderer.enabled = true;
        coll.enabled = true;
        Reposition();
    }
}
