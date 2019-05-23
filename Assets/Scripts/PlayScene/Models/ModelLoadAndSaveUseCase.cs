public class ModelLoadAndSaveUseCase
{
    private UserRepository _userRepository = null;

    public ModelLoadAndSaveUseCase()
    {
        _userRepository = new UserRepository();
    }

    public UserModel GetUser()
    {
        UserEntity userEntity = _userRepository.Get();

        if (userEntity == null)
        {
            return new UserModel();
        }
        else
        {
            return new UserModel(userEntity);
        }
    }

    public void PutUser(UserModel user)
    {
        _userRepository.Put(user.ToEntity());
    }
}