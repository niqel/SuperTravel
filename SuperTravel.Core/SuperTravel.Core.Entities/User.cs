using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Core.Entities
{
    public class User
    {
        private int userId;
        private string name;
        private string nickname;
        private string password;
        private bool isActive;
        private int createdBy;
        private DateTime createdAt;
        private int updatedBy;
        private DateTime updatedAt;

        public int UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Password { get => password; set => password = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public int CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public int UpdatedBy { get => updatedBy; set => updatedBy = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }

        public User()
        {
            this.userId = 0;
            this.name = string.Empty;
            this.nickname = string.Empty;
            this.password = string.Empty;
            this.isActive = true;
            this.createdBy = 0;
            this.createdAt = DateTime.MinValue;
            this.updatedBy = 0;
            this.updatedAt = DateTime.MinValue;
        }

        public User(int userId, string name, string nickname, string password, bool isActive, int createdBy, DateTime createdAt, int updatedBy, DateTime updatedAt)
        {
            this.userId = userId;
            this.name = name;
            this.nickname = nickname;
            this.password = password;
            this.isActive = isActive;
            this.createdBy = createdBy;
            this.createdAt = createdAt;
            this.updatedBy = updatedBy;
            this.updatedAt = updatedAt;
        }
    }
}
