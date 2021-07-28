using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idle_Game
{
    public interface Interfaces
    {
        void UpdateScreenPotion();
        void UpdateScreenUpgradedPotion();
        void UpdateScreenSuperPotion();
        void UpdateScreenUltraPotion();

        void UpdadeScreen();

        void UpdateScreenHeal();
        void UpdateScreenHeal2();
        void UpdateScreenHeal3();

        void UpdateScreenButton();
        void UpdateScreenButtonOff();
        void UpdateScreenNewGame();
        void UpdateScreenNewGameClicks(); 
    }
}