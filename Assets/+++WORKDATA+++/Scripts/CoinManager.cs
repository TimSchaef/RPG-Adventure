using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int counterCoins = 0; 
    [SerializeField] private UIManager uIManager;
    [SerializeField] private UIManager uiManager;
    


    private void Start()
    {
        counterCoins = 0;
        uIManager.UpdateCoinText(counterCoins);
        
    }
    public void AddCoin()
    {
        counterCoins++;
        uIManager.UpdateCoinText(counterCoins);
        if (counterCoins >= 10)
        {
            Debug.Log("You Win!!!!");
            uiManager.ShowWinPanel();
        }
        
    }

    public bool WinCondition()
    {
        if (counterCoins == 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
