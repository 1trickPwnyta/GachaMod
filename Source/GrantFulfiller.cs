using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;

namespace GachaMod
{
    public static class GrantFulfiller
    {
        public static Thing FulfillThing(string defName, ThingDef stuff, QualityCategory quality)
        {
            ThingStuffPairWithQuality pair = new ThingStuffPairWithQuality(ThingDef.Named(defName), stuff, quality);
            Thing thing = pair.MakeThing();
            return thing;
        }

        public static Pawn FulfillCharacter(string firstName, string lastName, string title, float age, Gender gender, float melanin, 
            string uniformDefName, string headgearDefName, string hairDefName, Color hairColor, string childhoodBackstory, string adulthoodBackstory, 
            IEnumerable<Trait> traits, IEnumerable<Skill> skills, int skillLevelCap)
        {
            Pawn character = PawnGenerator.GeneratePawn(new PawnGenerationRequest
            (
                Faction.OfPlayer.def.basicMemberKind,   // kind
                Faction.OfPlayer,                       // faction
                PawnGenerationContext.NonPlayer,        // context
                -1,                                     // tile
                true,                                   // forceGenerateNewPawn
                false,                                  // newborn
                false,                                  // allowDead
                false,                                  // allowDowned
                false,                                  // canGeneratePawnRelations
                true,                                   // mustbeCapableOfViolence
                0f,                                     // colonistRelationChanceFactor
                false,                                  // forceAddFreeWarmLayerIfNeeded
                true,                                   // allowGay
                true,                                   // allowFood
                true,                                   // allowAddictions
                false,                                  // inhabitant
                false,                                  // certainlyBeenInCryptosleep
                false,                                  // forceRedressWorldPawnIfFormerColonist
                false,                                  // worldPawnFactionDoesntMatter
                0f,                                     // biocodeWeaponChance
                0f,                                     // biocodeApparelChance
                null,                                   // extraPawnForExtraRelationChance
                1f,                                     // relationWithExtraPawnChanceFactor
                null,                                   // validatorPreGear
                null,                                   // validatorPostGear
                null,                                   // forcedTraits
                null,                                   // prohibitedTraits
                null,                                   // minChanceToRedressWorldPawn
                age,                                    // fixedBiologicalAge
                null,                                   // fixedChronologicalAge
                gender,                                 // fixedGender
                melanin,                                // fixedMelanin
                null,                                   // fixedLastName
                null,                                   // fixedBirthName
                null,                                   // fixedTitle
                Faction.OfPlayer.ideos.PrimaryIdeo      // fixedIdeo
            ));

            character.Name = new NameTriple(firstName, firstName, lastName);
            character.story.title = title;

            if (gender == Gender.Female)
            {
                character.story.bodyType = BodyTypeDefOf.Female;
            }
            if (gender == Gender.Male)
            {
                character.story.bodyType = BodyTypeDefOf.Male;
            }

            if (uniformDefName != null || headgearDefName != null)
            {
                character.apparel.DestroyAll();
            }
            if (uniformDefName != null)
            {
                Apparel uniform = new Apparel();
                uniform.def = ThingDef.Named(uniformDefName);
                uniform.HitPoints = uniform.MaxHitPoints;
                character.apparel.Wear(uniform);
            }
            if (headgearDefName != null)
            {
                Apparel headgear = new Apparel();
                headgear.def = ThingDef.Named(headgearDefName);
                headgear.HitPoints = headgear.MaxHitPoints;
                character.apparel.Wear(headgear);
            }
            character.story.hairDef = DefDatabase<HairDef>.GetNamed(hairDefName);
            character.story.hairColor = hairColor;

            if (childhoodBackstory != null)
            {
                character.story.childhood = BackstoryDatabase.allBackstories.Values.Where(delegate (Backstory story) { return story.title == childhoodBackstory; }).FirstOrFallback(null);
            }
            if (adulthoodBackstory != null)
            {
                character.story.adulthood = BackstoryDatabase.allBackstories.Values.Where(delegate (Backstory story) { return story.title == adulthoodBackstory; }).FirstOrFallback(null);
            }

            List < Trait > traitsToRemove = new List<Trait>(character.story.traits.allTraits);
            foreach (Trait trait in traitsToRemove)
            {
                if (trait.def != TraitDefOf.Gay && trait.def != TraitDefOf.Bisexual && trait.def != TraitDef.Named("Straight") && trait.def != TraitDefOf.Asexual)
                {
                    character.story.traits.RemoveTrait(trait);
                }
            }
            foreach (Trait trait in traits)
            {
                character.story.traits.GainTrait(trait);
            }

            if (skillLevelCap > -1)
            {
                foreach (SkillDef def in new List<SkillDef> { SkillDefOf.Shooting, SkillDefOf.Melee, SkillDefOf.Construction, SkillDefOf.Mining, SkillDefOf.Cooking, SkillDefOf.Plants, SkillDefOf.Animals, SkillDefOf.Crafting, SkillDefOf.Artistic, SkillDefOf.Medicine, SkillDefOf.Social, SkillDefOf.Intellectual })
                {
                    character.skills.GetSkill(def).Level = Math.Min(character.skills.GetSkill(def).Level, skillLevelCap);
                    character.skills.GetSkill(def).passion = Passion.None;
                }
            }
            foreach (Skill skill in skills)
            {
                character.skills.GetSkill(skill.def).Level = skill.level;
                character.skills.GetSkill(skill.def).passion = skill.passion;
            }

            return character;
        }
    }
}
