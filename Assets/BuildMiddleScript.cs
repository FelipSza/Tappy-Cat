using UnityEngine;

public class BuildMiddleScript : MonoBehaviour
{
    public GameMaster master;

    void Start()
    {
        master = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            master.addScore(1);
        }
    }
}
