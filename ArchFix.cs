using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kingmaker;
using Kingmaker.Blueprints;
using Kingmaker.UnitLogic.ActivatableAbilities;

namespace ArchaeologistFix
{
    static class ArchFix
    {
        static LibraryScriptableObject library => Main.library;

        static BlueprintActivatableAbility archaeologistLuck;
        
        public static void Load()
        {
            var library = Main.library;

            archaeologistLuck = library.Get<BlueprintActivatableAbility>("12dc796147c42e04487fcad3aaa40cea");

            archaeologistLuck.Group = ActivatableAbilityGroup.BardicPerformance;
        }
    }
}
