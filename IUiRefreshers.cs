namespace ClickNFight
{
    public interface IUiRefreshers
    {
        void UpdateUi();

        void UpdateScreenHeal();
        void UpdateScreenHeal2();
        void UpdateScreenHeal3();

        void UpdateScreenButton();
        void UpdateScreenButtonOff();
        void UpdateScreenNewGame();
        void UpdateScreenNewGameClicks(); 
    }
}