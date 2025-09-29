using UnityEngine;
using UnityEngine.UI; // For UI updates

public class CoinCollector : MonoBehaviour
{
    public Text coinCountText; // Assign this in the Inspector
    private int coinsCollected = 0;

    void Start()
    {
        UpdateCoinCountUI();
    }

    private void OnTriggerEnter(Collider other) // For 3D
    {
        if (other.CompareTag("Coin"))
        {
            coinsCollected++;
            UpdateCoinCountUI();
            Destroy(other.gameObject); // Remove the coin
        }
    }
    void UpdateCoinCountUI()
    {
        if (coinCountText != null)
        {
            coinCountText.text = "Coins: " + coinsCollected.ToString();
        }
    }
}