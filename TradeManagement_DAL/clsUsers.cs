using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsUsers : clsCommon
    {
        public DataTable GetAllUsers()
        {
            return Query("SELECT * FROM Users WHERE usrIsActive = 1 AND usrIsDelete = 0");
        }

        public DataTable GetAllUserGroups()
        {
            return Query("SELECT grpUserGroupName FROM UserGroups WHERE grpIsActive = 1 AND grpIsDelete = 0");
        }

        public bool IsUserNameUsed(string usrUserName)
        {
            return Query($"SELECT * FROM Users WHERE usrUserName = '{usrUserName}'").Rows.Count > 0;
        }

        public bool InsertUser(string usrUserName, string usrPassword, string usrUserGroupName, string usrIsActive, string usrInsertBy)
        {
            return Command(
                $"INSERT INTO Users (usrUserName, usrPassword, usrUserGroupName, usrIsActive, usrInsertBy, usrInsertDate) Values ('{usrUserName}','{usrPassword}','{usrUserGroupName}',{usrIsActive},'{usrInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateUser(string usrUserName, string usrPassword, string usrUserGroupName, string usrIsActive, string usrUpdateBy)
        {
            return Command(
                $"UPDATE Users SET usrPassword = '{usrPassword}', usrUserGroupName = '{usrUserGroupName}', usrIsActive = {usrIsActive}, usrUpdateBy = '{usrUpdateBy}', usrUpdateDate = '{DateTime.Now}' WHERE usrUserName = '{usrUserName}'");
        }

        public bool DeleteUser(string usrUserName, string usrDeleteBy)
        {
            return Command(
                $"UPDATE Users SET usrIsDelete = 1, usrDeleteBy = '{usrDeleteBy}', usrDeleteDate = '{DateTime.Now}' WHERE usrUserName = '{usrUserName}'");
        }
    }
}
