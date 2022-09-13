using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Noelle : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Noelle",
                "Favonius",
                "Maid",
                24f,
                Gender.Female,
                0f,
                "Noelle_uniform",
                "Noelle_headgear",
                "Noelle",
                new Color(1f, 1f, 1f),
                "serving girl",
                "house servant",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Kind),
                    new Trait(TraitDefOf.Industriousness, 1),
                    new Trait(TraitDefOf.NaturalMood, -1)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 6),
                    new Skill(SkillDefOf.Mining, Passion.Minor, 3),
                    new Skill(SkillDefOf.Cooking, Passion.Major, 6),
                    new Skill(SkillDefOf.Medicine, Passion.Minor, 3)
                },
                6
            );
        }
    }
}
