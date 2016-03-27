using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsUserGroups : clsCommon
    {
        public DataTable GetAllUserGroups()
        {
            return Query("SELECT * FROM UserGroups WHERE grpIsDelete = 0");
        }

        public bool IsGroupNameUsed(string grpUserGroupName)
        {
            return Query($"SELECT * FROM UserGroups WHERE grpUserGroupName = '{grpUserGroupName}'").Rows.Count > 0;
        }

        public bool IsRefferedInUsers(string usrUserGroupName)
        {
            return Query($"SELECT * FROM Users WHERE usrUserGroupName = '{usrUserGroupName}' AND usrIsActive = 1").Rows.Count > 0;
        }

        public bool InsertUserGroup(string grpUserGroupName, string grpIsActive, string grpInsertBy)
        {
            return Command(
                $"INSERT INTO UserGroups (grpUserGroupName, grpIsActive, grpInsertBy, grpInsertDate) Values ('{grpUserGroupName}',{grpIsActive},'{grpInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateUserGroup(string grpUserGroupName, string grpIsActive, string grpUpdateBy)
        {
            return Command(
                $"UPDATE UserGroups SET grpIsActive = {grpIsActive}, grpUpdateBy = '{grpUpdateBy}', grpUpdateDate = '{DateTime.Now}' WHERE grpUserGroupName = '{grpUserGroupName}'");
        }

        public bool DeleteUserGroup(string grpUserGroupName, string grpDeleteBy)
        {
            return Command(
                $"UPDATE UserGroups SET grpIsDelete = 1, grpDeleteBy = '{grpDeleteBy}', grpDeleteDate = '{DateTime.Now}' WHERE grpUserGroupName = '{grpUserGroupName}'");
        }

        public string GetPermission(string grpUserGroupName)
        {
            return Query($"SELECT grpPermission FROM UserGroups WHERE grpUserGroupName = '{grpUserGroupName}'").Rows[0]["grpPermission"].ToString();
        }

        public bool UpdatePermission(string grpUserGroupName, string grpPermission, string grpUpdateBy)
        {
            return Command(
                $"UPDATE UserGroups SET grpPermission = '{grpPermission}', grpUpdateBy = '{grpUpdateBy}', grpUpdateDate = '{DateTime.Now}' WHERE grpUserGroupName = '{grpUserGroupName}'");
        }
    }
}