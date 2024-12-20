using UnityEngine;

public class Damage : MonoBehaviour
{
    Player player;

    int life = 0;
    int initLife = 3;

    void Start()
    {
        life = initLife;
        player = GetComponent<Player>();
        GameManager.instance.OnLifeUpdate += UpdateLife;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent(out Enemy _enemy) && life > 0)
        {
            if (_enemy.level >= player.level)
            {
                life--;
                GameManager.instance.Life = life;

                if (life == 0)
                {
                    GameManager.instance.isGameOver = true;
                    GameManager.UI.ShowDie();
                }
            }

            else if (_enemy.level < player.level)
                GameManager.QuestManager.QuestProgress((int)player.level, 1);
        }
    }

    void UpdateLife(int life)
        => this.life = life;

    void OnDestroy()
    {
        if (GameManager.instance != null)
            GameManager.instance.OnLifeUpdate -= UpdateLife;
    }
}
