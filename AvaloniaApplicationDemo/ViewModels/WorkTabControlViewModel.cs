using DataGridExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaApplicationDemo.ViewModels
{
    public class WorkTabControlViewModel : ViewModelBase
    {
        public List<UserModel> Users { get; set; }

        public WorkTabControlViewModel()
        {
            Users = new List<UserModel>(GenerateUserTable());
        }

        private List<UserModel> GenerateUserTable()
        {
            List<UserModel> retUsers = new List<UserModel>()
            {
                new UserModel()
                {
                    OpdNo="A001",
                    Name="����",
                    Reserve="���",
                    Client="����1",
                    State=1,
                    IsNow = true,
                    IsWait = false
                },
                    new UserModel()
                {
                    OpdNo="A002",
                    Name="ͼƬ",
                    Reserve="���",
                    Client="����1",
                    State=0,
                      IsNow = false,
                    IsWait = true
                },
                        new UserModel()
                {
                   OpdNo="A003",
                    Name="�з�",
                    Reserve="���",
                    Client="����1",
                    State=0,
                       IsNow = false,
                    IsWait = true
                },
                new UserModel()
                {
                   OpdNo="A004",
                    Name="ͼƬ",
                    Reserve="���",
                    Client="����1",
                    State=0,
                       IsNow = false,
                    IsWait = true
                }
            };
            return retUsers;
        }

    }
}
