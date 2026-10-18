using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    public Vector2 minRange;
    public Vector2 maxRange;

    public Shooter shooter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
        shooter = GetComponent<Shooter>();
    }


    // Update is called once per frame
    public abstract void Update();

    public abstract void Move(Vector3 direction);

    public abstract void MoveWorldSpace(Vector3 direction);

    public abstract void Rotate(float speed);

    public abstract void Teleport();

    public abstract void Shoot();
}
