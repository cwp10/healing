using UnityEngine;

public class UserRepository
{
    protected string KEY = "UserEntity";

    public UserEntity Get()
    {
        string json = PlayerPrefs.GetString(KEY);

        if (string.IsNullOrEmpty(json))
        {
            return null;
        }
        else
        {
            return JsonUtility.FromJson<UserEntity>(json);
        }
    }

    public void Put(UserEntity entity)
    {
        string json = JsonUtility.ToJson(entity);
        PlayerPrefs.SetString(KEY, json);
    }
}
