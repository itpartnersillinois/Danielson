﻿using Danielson.Data.Data;
using Danielson.Data.DataModels;

namespace Danielson.Data.Login {

    public class UserAccess(FormRepository testRepository, string? testingString) {
        private readonly bool _testing = (testingString ?? "") == "testing";
        private readonly FormRepository _testRepository = testRepository;
        public bool IsTesting => _testing;

        public async Task<(string email, string username, RoleEnum role, string studentId)> Get(Guid guid) {
            var user = await _testRepository.ReadAsync(r => r.Users.FirstOrDefault(u => u.Guid == guid && (_testing || u.IsActive)));
            if (user == null) {
                return ("", "", RoleEnum.None, "");
            }
            _ = await _testRepository.ChangeActiveAsync(user, false);
            return (user.Email, user.Username, user.Role, user.StudentId.ToString());
        }

        public async Task<(string email, string username, RoleEnum role)> GetByName(string username) {
            var user = await _testRepository.ReadAsync(r => r.Users.FirstOrDefault(u => u.Username == username));
            return user == null ? ((string email, string username, RoleEnum role)) ("", "", RoleEnum.None) : ((string email, string username, RoleEnum role)) (user.Email, user.Username, user.Role);
        }
    }
}