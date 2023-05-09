namespace ProgramFirstFunction.CheckerPassword
{
    public class CheckerPassword : ICheckerPassword
    {
        public string ErrorMessage() => string.Empty;

        public bool IsValid(string password) => !string.IsNullOrWhiteSpace(password);
    }
}