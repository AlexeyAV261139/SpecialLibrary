using SpecialLibrary.Context;
using SpecialLibrary.Extensions;
using SpecialLibrary.Models;

namespace SpecialLibrary.Views.Dialogs
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private async void AddUserButton_Click(object sender, EventArgs e)
            => await MessageBoxExtensions.TryCatch(async () =>
            {
                if (string.IsNullOrWhiteSpace(FioTB.Text))
                {
                    MessageBox.Show("ФИО пользователя не должно быть пустым");
                    return;
                }

                var user = new User
                {
                    Id = 0,
                    IsLibraryWorker = false,
                    Name = FioTB.Text,
                };

                await SpecialLibraryDbContext.Shared
                    .Users
                    .AddAsync(user);
                await SpecialLibraryDbContext.Shared
                    .SaveChangesAsync();

                Close();
            });
    }
}
