using Microsoft.EntityFrameworkCore;
using SpecialLibrary.Context;
using SpecialLibrary.Extensions;
using SpecialLibrary.Models;

namespace SpecialLibrary.Views.Dialogs
{
    public partial class GetOrderBackForm : Form
    {
        public GetOrderBackForm()
        {
            InitializeComponent();
        }

        private int _firstItemIndex = 0;
        private List<User> _users = new();

        private void UpdateOrdersLB(User user)
        {
            OrdersLB.Items.Clear();
            OrdersLB.Items.AddRange(user.OrderInfoUsers
                   .Select(x => x.OrderInfo)
                   .ToArray());
        }

        private async void GetOrderBackForm_Load(object sender, EventArgs e)
            => await MessageBoxExtensions.TryCatch(async () =>
            {
                await UpdateUsersLB();
            });

        private async Task UpdateUsersLB()
        {
            await GetUsers();
            UsersLB.Items.Clear();
            UsersLB.Items.AddRange(_users.ToArray());

            UsersLB.SelectedIndex = _firstItemIndex;
            User user = (User)UsersLB.Items[_firstItemIndex];

            UpdateOrdersLB(user);
        }

        private async Task GetUsers()
        {
            _users = await SpecialLibraryDbContext.Shared
                .Users
                .Include(x => x.OrderInfoUsers)
                    .ThenInclude(x => x.OrderInfo)
                .ToListAsync();
        }

        private void UsersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = (User)UsersLB.Items[UsersLB.SelectedIndex];
            UpdateOrdersLB(selectedUser);
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
            => await MessageBoxExtensions.TryCatch(async () =>
            {
                if (UsersLB.SelectedItem is not User user)
                {
                    MessageBox.Show("Выберите юзера!");
                    return;
                }

                if (OrdersLB.SelectedItem is not OrderInfo order)
                {
                    MessageBox.Show("Выберите приказ!");
                    return;
                }


                var usersOrderInfo = user.OrderInfoUsers.First(x => x.OrderInfoId == order.Id);

                SpecialLibraryDbContext.Shared
                    .OrderInfoUsers
                    .Remove(usersOrderInfo);


                //SpecialLibraryDbContext.Shared
                //    .ChangeTracker
                //    .Clear();
                //SpecialLibraryDbContext.Shared
                //    .Orders
                //    .Update(order with
                //    {
                //        IsAwarded = false,
                //    });

                await SpecialLibraryDbContext.Shared
                    .SaveChangesAsync();


                Close();
            });
    }
}
