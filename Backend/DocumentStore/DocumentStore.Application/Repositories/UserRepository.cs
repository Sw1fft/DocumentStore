using DocumentStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using DocumentStore.Domain.Models;
using DocumentStore.Data.Entities;
using DocumentStore.Data;
using AutoMapper;

namespace DocumentStore.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DocumentStoreDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserRepository(DocumentStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UserModel> GetUserByEmail(string email)
        {
            var entity = await _dbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == email)
                ?? throw new NullReferenceException();

            return _mapper.Map<UserModel>(entity);
        }

        public async Task<UserModel> GetUserById(Guid userId)
        {
            var entity = await _dbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == userId)
                ?? throw new NullReferenceException();

            return _mapper.Map<UserModel>(entity);
        }

        public async Task RegisterUser(UserModel user)
        {
            var isUser = _dbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == user.Email);

            if (isUser.Result != null)
            {
                throw new Exception("User already exist");
            }

            var entity = new UserEntity
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                PasswordHash = user.PasswordHash
            };

            await _dbContext.Users.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
