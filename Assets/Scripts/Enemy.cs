using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitPoints = 3;
    [SerializeField] int score = 10;

    Scoreboard scoreboard;
    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }
    bool isDead = false;

    private void OnParticleCollision(GameObject other)
    {
        if (isDead) return;

        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            scoreboard.increaseScore(score);
            Instantiate(destroyedVFX, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}