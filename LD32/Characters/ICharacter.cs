using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LD32.Characters
{
    interface ICharacter
    {
        void DrawCharacter();
        void UpdateCharacter();
        void LoadCharacter();
    }
}
