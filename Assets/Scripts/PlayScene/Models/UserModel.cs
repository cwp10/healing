using UnityEngine;

public class UserModel
{
    private const int kBaseVitalPoint = 5;

    public string NickName { get; private set; }
    public int VitalityLevel { get; private set; }
    public double TotalVitality { get; private set; }

    private double _vitalityPerTap = 0;

    public UserModel(UserEntity entity)
    {
        NickName = entity.nickName;
        VitalityLevel = entity.vitalityLevel;
        TotalVitality = entity.totalVitality;

        UpdateParameter();
    }

    public UserModel() : this(
        new UserEntity()
        {
            nickName = string.Empty,
            vitalityLevel = 1,
            totalVitality = 0,
        }
    )
    { }

    public UserEntity ToEntity()
    {
        return new UserEntity()
        {
            nickName = NickName,
            vitalityLevel = VitalityLevel,
            totalVitality = TotalVitality,
        };
    }

    public double VitalityPerTap 
    {
        get { return _vitalityPerTap; }
    }

    public void AddVitality(double vitality)
    {
        TotalVitality += vitality;
    }

    private void UpdateParameter()
    {
        _vitalityPerTap = kBaseVitalPoint * (double)Mathf.Pow(1.15f, VitalityLevel - 1);
    }
}