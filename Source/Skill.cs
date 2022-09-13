using RimWorld;

namespace GachaMod
{
    public class Skill
    {
        public SkillDef def;
        public Passion passion;
        public int level;

        public Skill(SkillDef def, Passion passion, int level)
        {
            this.def = def;
            this.passion = passion;
            this.level = level;
        }
    }
}
