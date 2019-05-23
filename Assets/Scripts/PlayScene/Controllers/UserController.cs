using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour
{
    private UserModel _userModel = null;
    private ModelLoadAndSaveUseCase _useCase = null;

    public static UserController Create(UserModel userModel, ModelLoadAndSaveUseCase useCase)
    {
        var go = new GameObject("UserController");
        var userController = go.AddComponent<UserController>();
        userController._userModel = userModel;
        userController._useCase = useCase;
        return userController;
    }

    private void OnApplicationPause(bool isPaused)
    {
        if (isPaused) PutData();
    }

    private void OnDestroy()
    {
        PutData();
    }

    private void PutData()
    {
        _useCase.PutUser(_userModel);
    }
}
