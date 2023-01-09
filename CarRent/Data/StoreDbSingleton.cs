using CarRent.Model;

namespace CarRent.Data
{
    public class StoreDbSingleton
    {
        public static StoreDbSingleton Instance { get; set; } = new StoreDbSingleton();
        public List<Store> DB_STORES = new List<Store>();
        private StoreDbSingleton()
        {
            Store store = new Store("teste", "teste", "teste");
            DB_STORES.Add(store);
        }
    }
}
