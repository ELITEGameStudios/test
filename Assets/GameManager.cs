using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform enemySpawnPos;
    [SerializeField] GameObject enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0.5f, 4);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        Instantiate(enemy, enemySpawnPos.position, transform.rotation);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
