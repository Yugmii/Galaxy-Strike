using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitPoints = 3;


    private void OnTriggerEnter(Collider other)
    {
        hitPoints--;
        //hitPoints = hitPoints - 1;

        ProcessHit();
    }

    private void ProcessHit()
    {
        if (hitPoints <= 0)
        {
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
