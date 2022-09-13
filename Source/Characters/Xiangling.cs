using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Xiangling : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Xiangling",
                "Mao",
                "Chef",
                18f,
                Gender.Female,
                0f,
                null,
                null,
                "Cute",
                new Color(0.15f, 0.2f, 0.5f),
                "child prodigy",
                null,
                new List<Trait>
                {
                    new Trait(TraitDef.Named("Gourmand")),
                    new Trait(TraitDefOf.NaturalMood, 1),
                    new Trait(TraitDefOf.SpeedOffset, 2)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Minor, 6),
                    new Skill(SkillDefOf.Cooking, Passion.Major, 6),
                    new Skill(SkillDefOf.Plants, Passion.Major, 5),
                    new Skill(SkillDefOf.Animals, Passion.Minor, 4)
                },
                6
            );
        }
    }
}
