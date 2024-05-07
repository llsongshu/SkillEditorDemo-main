
public class FightAtkHanle 
{   //������С�غϵȴ���϶
    private FightSkillHandle skillHandle;
    private FightField fightField;
    public FightAtkHanle(FightField fightField)
    { 
        this.skillHandle = new FightSkillHandle(fightField);
        this.fightField = fightField;
    }

    public RoundInfo ParseCmd(RoundCmd roundCmd,C_SkillConfig c_SkillConfig) 
    {
        return skillHandle.ParseCmd(roundCmd, c_SkillConfig);
    }
}
