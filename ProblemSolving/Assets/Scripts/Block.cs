using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    Rect latestBorder;

    public void Reposition()
    {
        Reposition(latestBorder);
    }

    public void Reposition(Rect border)
    {
        latestBorder = border;

        float x = Random.Range(border.x, border.x + border.width);
        float y = Random.Range(border.y, border.y + border.height);

        transform.position = new Vector2(x, y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.SetActive(false);
            ScoreManager.AddScore();
        }
    }
}
