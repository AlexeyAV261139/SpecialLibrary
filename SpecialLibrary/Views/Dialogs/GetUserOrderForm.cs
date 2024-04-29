using Microsoft.EntityFrameworkCore;
using SpecialLibrary.Context;
using SpecialLibrary.Extensions;
using SpecialLibrary.Models;
using System.Data;

namespace SpecialLibrary.Views.Dialogs
{
    public partial class GetUserOrderForm : Form
    {
        public GetUserOrderForm()
        {
            InitializeComponent();
        }

        private async void GetUserOrderForm_Load(object sender, EventArgs e)
            => await MessageBoxExtensions.TryCatch(async () =>
            {
                UsersLB.Items.AddRange(await SpecialLibraryDbContext.Shared
                    .Users
                    .ToArrayAsync());

                OrdersLB.Items.AddRange(await SpecialLibraryDbContext.Shared
                    .Orders
                    .Where(x => !x.IsAwarded)
                    .ToArrayAsync());
            });

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

                await SpecialLibraryDbContext.Shared
                    .OrderInfoUsers
                    .AddAsync(new OrderInfoUser
                    {
                        UserId = user.Id,
                        OrderInfoId = order.Id,
                    });
                SpecialLibraryDbContext.Shared
                    .Orders
                    .Update(order with
                    {
                        IsAwarded = true,
                    });
                await SpecialLibraryDbContext.Shared
                    .SaveChangesAsync();

                Close();
            });
    }
}
