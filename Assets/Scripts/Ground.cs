using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public BoxCollider2D bc2d;
    public float groundHorizontalLength;
    // Start is called before the first frame update
    void Start()
    {
        bc2d = GetComponent<BoxCollider2D>();
        groundHorizontalLength = bc2d.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        Vector2 PositionOffset = new Vector2(groundHorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + PositionOffset;
    }
}
