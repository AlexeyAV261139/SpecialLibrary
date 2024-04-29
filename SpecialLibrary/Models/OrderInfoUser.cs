namespace SpecialLibrary.Models
{
    internal record OrderInfoUser
    {
        public required int OrderInfoId { get; init; }
        public required int UserId { get; init; }

        public OrderInfo OrderInfo { get; init; } = null!;
        public User User { get; init; } = null!;
    }
}
