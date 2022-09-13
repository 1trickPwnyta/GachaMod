using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace GachaMod.Characters
{
    public class Kaeya : Character
    {
        public override Pawn Make()
        {
            return GrantFulfiller.FulfillCharacter
            (
                "Kaeya",
                "Alberich",
                "Cavalry Captain",
                26f,
                Gender.Male,
                0.5f,
                "Kaeya_uniform",
                null,
                "Kaeya",
                new Color(1f, 1f, 1f),
                "adventuring child",
                "intelligence agent",
                new List<Trait>
                {
                    new Trait(TraitDefOf.Transhumanist),
                    new Trait(TraitDefOf.SpeedOffset, 1),
                    new Trait(TraitDefOf.Industriousness, -1)
                },
                new List<Skill>
                {
                    new Skill(SkillDefOf.Melee, Passion.Major, 6),
                    new Skill(SkillDefOf.Social, Passion.Major, 6),
                    new Skill(SkillDefOf.Construction, Passion.Minor, 4)
                },
                6
            );
        }
    }
}
