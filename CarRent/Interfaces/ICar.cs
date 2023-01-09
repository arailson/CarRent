using CarRent.Enum;

namespace CarRent.Interfaces
{
    public interface ICar
    {
        public ECategory Category { get; set; }
        public EStatus Status { get; set; }
    }
}
