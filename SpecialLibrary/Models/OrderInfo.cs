namespace SpecialLibrary.Models
{
    internal record OrderInfo
    {
        public required int Id { get; init; }
        public required string Title { get; init; }
        public required OrderInfoType Type { get; init; }
        public required OrderInfoSecurityLevel SecurityLevel { get; init; }
        public required DateTime CreateDate { get; init; }
        public required string Location { get; init; }
        public required bool IsAwarded { get; init; }

        public List<OrderInfoUser> OrderInfoUsers { get; init; } = new List<OrderInfoUser>();

        public override string ToString()
            => $"({Id}) {Title}";
    }
}
