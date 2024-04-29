using Microsoft.EntityFrameworkCore;
using SpecialLibrary.Context;
using SpecialLibrary.Extensions;
using SpecialLibrary.Models;
using SpecialLibrary.Views.Dialogs;
using System.Text;

namespace SpecialLibrary.Views
{
    public enum TargetPropertyCBOptions
    {
        Title,
        Id,
        SecurityLevel,
        Type,
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Enum.GetValues<TargetPropertyCBOptions>()
                .ToList()
                .ForEach(x => TargetPropertyCB.Items.Add(x));
            TargetPropertyCB.DropDownStyle = ComboBoxStyle.DropDownList;
            TargetPropertyCB.SelectedIndex = 0;

            ConfigureOrdersDGV();
            ConfigureLibraryWorkersDGV();
        }

        private ValueTask LoadAsync()
            => MessageBoxExtensions.TryCatch(async () =>
            {
                OrdersDGV.Rows.Clear();
                LibraryWorkersDGV.Rows.Clear();
                SearchTB.Text = string.Empty;

                (await SpecialLibraryDbContext.Shared
                    .Orders
                    .ToListAsync())
                    .ForEach(AddOrderToOrdersDGV);

                (await SpecialLibraryDbContext.Shared
                    .Users
                    .Where(x => x.IsLibraryWorker)
                    .ToListAsync())
                    .ForEach(AddUserToLibraryWorkersDGV);
            });

        #region Настройка таблиц

        private void ConfigureOrdersDGV()
        {
            OrdersDGV.Columns.Add(nameof(OrderInfo.Id), "Номер");
            OrdersDGV.Columns.Add(nameof(OrderInfo.Title), "Наименование");
            OrdersDGV.Columns.Add(nameof(OrderInfo.Type), "Тип");
            OrdersDGV.Columns.Add(nameof(OrderInfo.SecurityLevel), "Гриф");
            OrdersDGV.Columns.Add(nameof(OrderInfo.CreateDate), "Дата создания");
            OrdersDGV.Columns.Add(nameof(OrderInfo.Location), "Местоположение");
            OrdersDGV.Columns.Add(nameof(OrderInfo.IsAwarded), "Выдано");

            OrdersDGV.Columns[0].ReadOnly = true;
            OrdersDGV.Columns[1].ReadOnly = true;
            OrdersDGV.Columns[2].ReadOnly = true;
            OrdersDGV.Columns[3].ReadOnly = true;
            OrdersDGV.Columns[4].ReadOnly = true;
            OrdersDGV.Columns[5].ReadOnly = true;
            OrdersDGV.Columns[6].ReadOnly = true;

            OrdersDGV.RowHeadersVisible = false;
            OrdersDGV.AllowUserToAddRows = false;
        }

        private void ConfigureLibraryWorkersDGV()
        {
            LibraryWorkersDGV.Columns.Add(nameof(User.Id), "Идентификатор");
            LibraryWorkersDGV.Columns.Add(nameof(User.Name), "ФИО");

            LibraryWorkersDGV.Columns[0].ReadOnly = true;
            LibraryWorkersDGV.Columns[1].ReadOnly = true;

            LibraryWorkersDGV.RowHeadersVisible = false;
            LibraryWorkersDGV.AllowUserToAddRows = false;
        }

        #endregion

        #region Вставка в таблицы

        private void AddOrderToOrdersDGV(OrderInfo order)
        {
            OrdersDGV.Rows.Add(
                order.Id,
                order.Title,
                order.Type.ToString(),
                order.SecurityLevel.ToString(),
                order.CreateDate.ToString("dd.MM.yyyy"),
                order.Location,
                order.IsAwarded);
        }

        private void AddUserToLibraryWorkersDGV(User user)
        {
            LibraryWorkersDGV.Rows.Add(
                user.Id,
                user.Name);
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
            => LoadAsync().ConfigureAwait(false);

        private async void SearchOrderButton_Click(object sender, EventArgs e)
            => await MessageBoxExtensions.TryCatch(async () =>
            {
                OrdersDGV.Rows.Clear();

                var searchOption = (TargetPropertyCBOptions)TargetPropertyCB.SelectedIndex;
                var searchTarget = SearchTB.Text;

                List<OrderInfo>? orderInfos = null;
                switch (searchOption)
                {
                    default:
                    case TargetPropertyCBOptions.Title:
                        orderInfos = await SpecialLibraryDbContext.Shared
                            .Orders
                            .Where(x => x.Title.Contains(searchTarget))
                            .ToListAsync();
                        break;
                    case TargetPropertyCBOptions.Id:
                        if (int.TryParse(searchTarget, out var targetId))
                        {
                            orderInfos = await SpecialLibraryDbContext.Shared
                                .Orders
                                .Where(x => x.Id == targetId)
                                .ToListAsync();
                        }
                        break;
                    case TargetPropertyCBOptions.SecurityLevel:
                        OrderInfoSecurityLevel? targetSecurityLevel = Enum.GetValues<OrderInfoSecurityLevel>()
                            .FirstOrDefault(x => x.ToString() == searchTarget);
                        if (targetSecurityLevel.HasValue)
                        {
                            orderInfos = await SpecialLibraryDbContext.Shared
                                .Orders
                                .Where(x => x.SecurityLevel == targetSecurityLevel)
                                .ToListAsync();
                        }
                        break;
                    case TargetPropertyCBOptions.Type:
                        OrderInfoType? targetType = Enum.GetValues<OrderInfoType>()
                             .FirstOrDefault(x => x.ToString() == searchTarget);
                        if (targetType.HasValue)
                        {
                            orderInfos = await SpecialLibraryDbContext.Shared
                                .Orders
                                .Where(x => x.Type == targetType)
                                .ToListAsync();
                        }
                        break;
                }

                orderInfos?.ForEach(AddOrderToOrdersDGV);
            });

        private async void ResetOrdersDGVButton_Click(object sender, EventArgs e)
            => await LoadAsync();

        // Получить отчёт о приказе
        private async void GetOrderInfoDocButton_Click(object sender, EventArgs e)
            => await MessageBoxExtensions.TryCatch(async () =>
            {

                int id = (int)OrdersDGV.CurrentRow.Cells[0].Value;
                var targetOrder = await SpecialLibraryDbContext.Shared
                    .Orders
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (targetOrder == null)
                    return;

                StringBuilder sb = new();
                sb.AppendLine($"Номер: {targetOrder.Id}");
                sb.AppendLine($"Наименование: {targetOrder.Title}");
                sb.AppendLine($"Тип: {targetOrder.Type}");
                sb.AppendLine($"Гриф: {targetOrder.SecurityLevel}");
                sb.AppendLine($"Дата создания: {targetOrder.CreateDate}");
                sb.AppendLine($"Местоположение: {targetOrder.Location}");
                sb.AppendLine($"Выдано: {targetOrder.IsAwarded}");

                string result = sb.ToString();

                MessageBox.Show(result);
            });

        // Получить отчёт о должниках
        private async void GetUsersDocButton_Click(object sender, EventArgs e)
            => await MessageBoxExtensions.TryCatch(async () =>
            {
                var targetUsers = await SpecialLibraryDbContext.Shared
                    .Users
                    .Include(x => x.OrderInfoUsers)
                        .ThenInclude(x => x.OrderInfo)
                    .Where(x => x.OrderInfoUsers.Any())
                    .ToListAsync();

                if (!targetUsers.Any())
                {
                    MessageBox.Show("Должников нет!");
                    return;
                }

                string result = string.Empty;
                foreach (var user in targetUsers)
                {
                    result += $"Пользователь {user.Name} должен:\r\n";
                    foreach (var item in user.OrderInfoUsers)
                    {
                        result += $"{item.OrderInfo.Title}\r\n";
                    }
                    result += "\r\n\r\n";
                }

                MessageBox.Show(result);
            });

        // Новый пользователь
        private async void AddNewUserButton_Click(object sender, EventArgs e)
        {
            new AddNewUserForm().ShowDialog();
            await LoadAsync();
        }

        // Выдать приказ
        private async void GetUserOrderButton_Click(object sender, EventArgs e)
        {
            new GetUserOrderForm().ShowDialog();
            await LoadAsync();  
        }

        // Вернуть приказ
        private async void GetOrderBackButton_Click(object sender, EventArgs e)
        {
            new GetOrderBackForm().ShowDialog();
            await LoadAsync();
        }
    }
}
