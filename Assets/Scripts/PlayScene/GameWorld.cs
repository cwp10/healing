using UnityEngine;

public class GameWorld : MonoBehaviour
{
    private ModelLoadAndSaveUseCase _useCase = null;
    private UserModel _userModel = null;

    public void OnTap(object sender, object[] args)
    {
        _userModel.AddVitality(_userModel.VitalityPerTap);
        Debug.Log("tap : " + Number.Converter(_userModel.VitalityPerTap) + "   totalVitality : " + Number.Converter(_userModel.TotalVitality));
    }

    private void Start()
    {
        _useCase = new ModelLoadAndSaveUseCase();
        _userModel = _useCase.GetUser();
        UserController.Create(_userModel, _useCase);
    }
}
