using UnityEngine;

public class SafeVolume : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        Death death = collision.GetComponent<Death>();
        
        if (death != null)
        {
            death.Die();
        }
    }
}
