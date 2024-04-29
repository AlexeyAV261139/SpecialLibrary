namespace SpecialLibrary.Models
{
    internal record User
    {
        public required int Id { get; init; }
        public required string Name { get; init; }

        public required bool IsLibraryWorker { get; init; }


        public List<OrderInfoUser> OrderInfoUsers { get; init; } = new List<OrderInfoUser>();

        public override string ToString()
            => $"({Id}) {Name}";
    }
}
