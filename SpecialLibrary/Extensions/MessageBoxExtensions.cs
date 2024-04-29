namespace SpecialLibrary.Extensions
{
    internal static class MessageBoxExtensions
    {
        public delegate ValueTask ValueTaskFunction();

        public static void ShowDefaultErrorMessage()
            => MessageBox.Show("Произошла ошибка приложения! Обратитесь к администратору.");

        public static async ValueTask TryCatch(ValueTaskFunction valueTaskFunction)
        {
            try
            {
                await valueTaskFunction();
            }
            catch(Exception)
            {
                ShowDefaultErrorMessage();
            }
        }
    }
}
