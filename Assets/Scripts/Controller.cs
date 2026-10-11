using UnityEngine;

public class Cotroller : MonoBehaviour
{
    public Pawn pawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if(pawn != null)
        {
            MakeDecisions();
        }
    }

     public abstract void MakeDecisions();
}
