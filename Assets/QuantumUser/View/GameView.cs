namespace Quantum
{
    using TMPro;
    using UnityEngine;

    public unsafe class GameView : QuantumEntityViewComponent
    {
        [SerializeField] private TextMeshProUGUI textWin;
        [SerializeField] private TextMeshProUGUI textLose;

        private bool showGameWin = false;
        private bool showGameLose = false;
        private void Awake()
        {
            textWin.gameObject.SetActive(false);
            textLose.gameObject.SetActive(false);
        }
        private void Update()
        {
            if (VerifiedFrame == null) return;

            if (VerifiedFrame.Global->CurrentGameState == GameState.Win && showGameWin == false)
            {
                textWin.gameObject.SetActive(true);
            }
            if (VerifiedFrame.Global->CurrentGameState == GameState.Lose && showGameLose == false)
            {
                textLose.gameObject.SetActive(true);
            }
        }
    }
}
