using Stylet;

namespace Company.WpfApplication1.Pages
{
    public class ShellViewModel : Screen
    {
        private string username;

        public string Username { get => username; set => SetAndNotify(ref username, value, nameof(Username)); }

        public void Do() { }

        public bool CanDo => !string.IsNullOrWhiteSpace(username);
    }
}
