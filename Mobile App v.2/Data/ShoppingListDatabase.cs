using Mobile_App_v._2.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App_v._2.Data
{
    public class ShoppingListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ShoppingListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ShopList>().Wait();
            _database.CreateTableAsync<Doctor>().Wait();
            _database.CreateTableAsync<Review>().Wait();
        }
        public Task<List<ShopList>> GetShopListsAsync()
        {
            return _database.Table<ShopList>().ToListAsync();
        }
        public Task<ShopList> GetShopListAsync(int id)
        {
            return _database.Table<ShopList>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveShopListAsync(ShopList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteShopListAsync(ShopList slist)
        {
            return _database.DeleteAsync(slist);
        }

        public Task<List<Review>> GetReviewAsync()
        {
            return _database.Table<Review>().ToListAsync();
        }

        public Task<int> SaveReviewAsync(Review review)
        {
            if (review.ReviewId != 0)
            {
                return _database.UpdateAsync(review);
            }
            else
            {
                return _database.InsertAsync(review);
            }
        }
        public Task<int> DeleteReviewAsync(Review review)
        {
            return _database.DeleteAsync(review);
        }

        public Task<List<Doctor>> GetDoctorAsync()
        {
            return _database.Table<Doctor>().ToListAsync();
        }

        public Task<int> SaveDoctorAsync(Doctor doctor)
        {
            if (doctor.DoctorID != 0)
            {
                return _database.UpdateAsync(doctor);
            }
            else
            {
                return _database.InsertAsync(doctor);
            }
        }
        public Task<int> DeleteDoctorAsync(Doctor doctor)
        {
            return _database.DeleteAsync(doctor);
        }

    }
}
