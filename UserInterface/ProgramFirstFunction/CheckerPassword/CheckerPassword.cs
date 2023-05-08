namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPassword : IChecker
    {
        private readonly string _password;

        public CheckerPassword(string password)
        {
            _password = password;
        }
        public bool IsValid() => !string.IsNullOrWhiteSpace(_password);
        public string ErrorMessage() => IsValid() ? string.Empty : "Password is Empty";
        public bool Check(string password) => throw new NotImplementedException();

        //public static bool IsStrongPassword(string password)
        //{
        //    if (string.IsNullOrWhiteSpace(password))
        //        return false;

        //    bool hasLength = password.Length >= 7;
        //    bool hasUpperCase = password.Any(char.IsUpper);
        //    bool hasNumber = password.Any(char.IsDigit);
        //    bool hasSpecialCharacter = password.Any(c => !char.IsLetterOrDigit(c));

        //    return hasLength && hasUpperCase && hasNumber && hasSpecialCharacter;
        //}
    }
}