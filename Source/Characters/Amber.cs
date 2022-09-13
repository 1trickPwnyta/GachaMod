using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Amber : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Amber",
                "Favonius",
                "Outrider",
                20f,
                Gender.Female,
                0f,
                "Amber_uniform",
                "Amber_headgear",
                "Amber",
                new Color(1f, 1f, 1f),
                "military trainee",
                "military engineer",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Kind),
                    new Trait(TraitDefOf.ShootingAccuracy, -1),
                    new Trait(TraitDefOf.NaturalMood, 1)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Shooting, Passion.Major, 6),
                    new Skill(SkillDefOf.Animals, Passion.Minor, 4),
                    new Skill(SkillDefOf.Crafting, Passion.Minor, 4),
                    new Skill(SkillDefOf.Social, Passion.Minor, 5)
                },
                6
            );
        }
    }
}
