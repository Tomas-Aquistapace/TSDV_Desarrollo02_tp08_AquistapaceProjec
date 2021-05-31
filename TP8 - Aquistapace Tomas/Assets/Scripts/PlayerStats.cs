using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int lifes = 3;
    public bool lose;

    void Start()
    {
        lose = false;
    }

    public void Die()
    {
        lifes--;

        if (lifes <= 0)
        {
            lose = true;
        }
    }
}
