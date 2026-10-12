using UnityEngine;

public class StarShipBot : Pawn
{
    private Transform tf;
    public override void Start()
    {
        tf = GetComponent<Transform>();
    }

    public override void Update()
    {
        
    }

    public override void Move(Vector3 direction)
    {
        tf.position = tf.position + direction.normalized * moveSpeed * Time.deltaTime;

    }

    public override void MoveWorldSpace(Vector3 direction)
    {
        Debug.Log("World Movement");
        tf.position = tf.position + direction.normalized;
    }

    public override void Rotate(float speed)
    {
        tf.Rotate(0.0f, 0.0f, speed * Time.deltaTime);
    }

    public override void Teleport()
    {
        // find random x value
        float randomX = Random.Range(minRange.x, maxRange.x);
        // find random y value
        float randomY = Random.Range(minRange.y, maxRange.y);

        // apply the random position to the sprites
        tf.position = new Vector2(randomX, randomY);
    }
}
